using PhoneConnector;
using PhoneConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbSync.Helpers;

namespace UsbSync
{
    public partial class SyncForm : Form
    {
        private IPhoneDrive _phoneDrive;
        private List<IPhoneFolder> _folders = new List<IPhoneFolder>();
        private string _saveLocation = "";

        private bool _cameraPhotos = false;
        private bool _folderMode = true;

        private Stack<string> _previewImages = new Stack<string>();
        private Timer _downloadTimer = new Timer();
        private Stack<string> _downloadFiles = new Stack<string>();
        private string _downloadLocation = string.Empty;

        public SyncForm()
        {
            InitializeComponent();
        }

        private void SyncForm_Load(object sender, EventArgs e)
        {
            Init();
            _downloadTimer.Interval = 5000;
            _downloadTimer.Tick += _downloadTimer_Tick;
        }

        private void _downloadTimer_Tick(object sender, EventArgs e)
        {
            _downloadTimer.Enabled = false;
            try
            {
                if (_downloadFiles.Count > 0)
                {
                    _downloadTimer.Enabled = true;
                    const int maxDownload = 10;
                    var counter = 0;
                    while (_downloadFiles.Count > 0 && counter < maxDownload)
                    {
                        var f = Utils.GetFileByPath(_downloadFiles.Pop());
                        loadingStatusLabel.Text = $"Download {f.Name}";
                        if (counter % 3 == 0)
                        {
                            this.Refresh();
                        }
                        Utils.CopyFile(f, _downloadLocation);
                    }
                }
                else
                {
                    loadingStatusLabel.Text = "Download is afgerond.";
                }
            }
            catch (Exception x) 
            {
                if (SettingsHelper.DebugMode)
                {
                    MessageBox.Show("Fout: " + x.Message + ", " + x.StackTrace);
                }
            }
        }

        public void Init()
        {
            if (SettingsHelper.DebugMode)
            {
                btnCopy.Visible = true;
            }
            _saveLocation = SettingsHelper.GetSavePath;
            if (!string.IsNullOrEmpty(_saveLocation))
            {
                saveLocationTree.Nodes.Clear();
                LoadSaveLocation(saveLocationTree.Nodes, _saveLocation);
                saveLocationTree.ExpandAll();
            }
            var path = string.Empty;
            if (_cameraPhotos)
            {
                path = SettingsHelper.MobilePhotoPath;
            }
            else
            {
                path = SettingsHelper.WhatsappPath;
            }
            if (!string.IsNullOrEmpty(path))
            {
                var folder = Utils.GetFolderByPath(path);
                LoadImagesOfFolder(folder);
            }
            var url = SettingsHelper.PreviewUrl;
            if (!string.IsNullOrEmpty(url))
            {
                previewBrowser.Url = new Uri(url);
            }
        }

        private void LoadSaveLocation(TreeNodeCollection tree, string location)
        {
            var locationCopy = location.TrimEnd(new char[] { Path.DirectorySeparatorChar });
            if (location.Last() != Path.DirectorySeparatorChar) 
            {
                location += Path.DirectorySeparatorChar;
            }
            var shortFolderName = locationCopy.Substring(locationCopy.LastIndexOf(Path.DirectorySeparatorChar)+1);
            var node = tree.Add(shortFolderName);
            node.Tag = location;
            var subFolders = Directory.GetDirectories(location);
            foreach (var folder in subFolders)
            {
                var subpath = Path.Combine(location, folder);
                LoadSaveLocation(node.Nodes, subpath);
            }
        }

        public void SetPhoneItem(IPhoneDrive phoneDrive, bool cameraPhotos)
        {
            _phoneDrive = phoneDrive;
            _cameraPhotos = cameraPhotos;
        }

        private void btnLoadFolders_Click(object sender, EventArgs e)
        {
            photoTree.Nodes.Clear();
            photoTree.CheckBoxes = false;
            loadingStatusLabel.Text = "Opvragen van alle mappen...";
            Refresh();
            foreach (var folder in _phoneDrive.Folders)
            {
                FillTreeWithFolders(photoTree.Nodes, folder);
            }
            loadingStatusLabel.Text = "Gereed: alle mappen geladen.";
            photoTree.ExpandAll();
            _folderMode = true;
        }

        private void FillTreeWithFolders(TreeNodeCollection tree, IPhoneFolder folder)
        {
            var node = tree.Add(folder.Name);
            node.Tag = folder.Path;
            if (radioFilter.Checked && SharedHelper.HasImages(folder))
            {
                node.ForeColor = Color.Red;
            }
            _folders.Add(folder);
            foreach (var subfolder in folder.Folders)
            {
                FillTreeWithFolders(node.Nodes, subfolder);
            }
        }

        private void LoadImagesOfFolder(IPhoneFolder folder)
        {
            if (folder == null)
            {
                return;
            }
            try
            {
                loadingStatusLabel.Text = folder.Name;
                _folderMode = false;
                photoTree.Nodes.Clear();
                photoTree.CheckBoxes = true;
                cmbMonthSelection.Items.Clear();
                cmbMonthSelection.Items.Add("Kies een maand om te selecteren.");
                cmbMonthSelection.SelectedIndex = 0;
                foreach (var item in folder.Files.OrderByDescending(rec => rec.LastWriteTime))
                {
                    var addedNode = photoTree.Nodes.Add($"{item.LastWriteTime.ToString("yyyy-MM-dd")} - {item.Name}");
                    addedNode.Tag = item.Path;
                    var selectionItem = item.LastWriteTime.ToString("yyyy-MM");
                    if (!cmbMonthSelection.Items.Contains(selectionItem))
                    {
                        cmbMonthSelection.Items.Add(selectionItem);
                    }
                }
            }
            catch (Exception) { }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            if (photoTree.SelectedNode == null)
            {
                return;
            }
            PreviewImage();
        }

        private void PreviewImage()
        {
            try
            {
                var fullPath = photoTree.SelectedNode.Tag.ToString();

                var file = Utils.GetFileByPath(fullPath);
                if (file == null) return;

                var tempLocation = SharedHelper.new_temp_path();
                Utils.CopyFile(file, tempLocation);

                var url = Path.Combine(tempLocation, file.Name);
                previewBrowser.Document.GetElementById("plaatje").SetAttribute("src", $"file://{url}");

                _previewImages.Push(url);
                removeTimer.Start();
            }
            catch (Exception x)
            { /* suppress */
                if (SettingsHelper.DebugMode)
                {
                    MessageBox.Show("Fout: " + x.Message + ", " + x.StackTrace);
                }
                else
                {
                    MessageBox.Show("Er kan geen voorbeeld getoond worden.");
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (photoTree.SelectedNode == null)
                {
                    return;
                }
                try
                {
                    var fullPath = photoTree.SelectedNode.Tag.ToString();
                    var file = Utils.GetFileByPath(fullPath);
                    if (file == null) return;

                    Clipboard.SetText(fullPath);
                }
                catch (Exception)
                { /* suppress */
                }
            }
            catch (Exception) { }
        }

        private void removeTimer_Tick(object sender, EventArgs e)
        {
            try {
                if (_previewImages.Any())
                {
                    var item = _previewImages.Pop();
                    File.Delete(item);
                    var folder = Path.GetDirectoryName(item);
                    Directory.Delete(folder);
                }
            }
            catch (Exception) { }
            finally {
                removeTimer.Stop();
            }
        }

        private void radioFilter_CheckedChanged(object sender, EventArgs e)
        {
            radioNoFilter.Checked = !radioFilter.Checked;
        }

        private void radioNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            radioFilter.Checked = !radioNoFilter.Checked;
        }

        private void cmbMonthSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonthSelection.SelectedIndex > 0)
            {
                CheckByDate(cmbMonthSelection.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!photoTree.CheckBoxes)
            {
                return;
            }
            CheckOrUncheck();
        }

        private void CheckOrUncheck(bool check=true)
        {
            foreach(TreeNode item in photoTree.Nodes)
            {
                item.Checked = check;
            }
        }

        private void CheckByDate(string date)
        {
            var doneChecking = false;
            foreach (TreeNode item in photoTree.Nodes)
            {
                if (item.Text.StartsWith($"{date}-"))
                {
                    item.Checked = true;
                    doneChecking = true;
                }
                else if (doneChecking)
                {
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!photoTree.CheckBoxes)
            {
                return;
            }
            CheckOrUncheck(false);
        }

        private void btnPhotoImport_Click(object sender, EventArgs e)
        {
            if (saveLocationTree.SelectedNode == null)
            {
                MessageBox.Show("Selecteer een map om de afbeeldingen op te slaan.");
                return;
            }
            var selectedCount = 0;
            var checkedFiles = new List<string>();
            foreach (TreeNode node in photoTree.Nodes)
            {
                if (node.Checked)
                {
                    selectedCount++;
                    checkedFiles.Add(node.Tag.ToString());
                }
            }
            if (selectedCount == 0)
            {
                MessageBox.Show("Er is geen foto geselecteerd.");
                return;
            }
            var saveLocation = saveLocationTree.SelectedNode;
            if (MessageBox.Show($"Wil je deze {selectedCount} foto's in de map {saveLocation.Text} opslaan?", "Bevestig import", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _downloadLocation = saveLocation.Tag.ToString();
                foreach (var selectedFile in checkedFiles)
                {
                    _downloadFiles.Push(selectedFile);
                }
                loadingStatusLabel.Text = "Start kopieren...";
                _downloadTimer.Enabled = true;
                return;
            }
            loadingStatusLabel.Text = "Kopieren geannuleerd.";
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            if (saveLocationTree.Nodes.Count == 0)
            {
                return;
            }
            var popup = new DirectoryCreateName();
            popup.SetFolderName($"{(_cameraPhotos ? "camera" : "whatsapp")}-{DateTime.Now.ToString("yyyy-MM")}");
            popup.ShowDialog();
            var folderName = popup.Tag.ToString();
            if (!string.IsNullOrEmpty(folderName))
            {
                var newFolder = Path.Combine(saveLocationTree.Nodes[0].Tag.ToString(), folderName);
                if (!Directory.Exists(newFolder))
                {
                    Directory.CreateDirectory(newFolder);
                }
                saveLocationTree.Nodes.Clear();
                LoadSaveLocation(saveLocationTree.Nodes, _saveLocation);
                saveLocationTree.ExpandAll();
            }
        }

        /// <summary>
        /// Go to files of this folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void photoTree_DoubleClick(object sender, EventArgs e)
        {
            if (photoTree.SelectedNode == null)
            {
                MessageBox.Show("Er is geen map aangeklikt.");
                return;
            }
            if (_folderMode)
            {
                LoadImagesOfFolder(Utils.GetFolderByPath(photoTree.SelectedNode.Tag.ToString()));
                return;
            }
            PreviewImage();

        }

    }
}
