using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneConnector;
using PhoneConnector.Interfaces;

namespace UsbSync
{
    public partial class MainForm : Form
    {
        private static List<IPhoneDrive> _availableDrives = new List<IPhoneDrive>();
        private static string _preferredPhone = "";

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            Connector.SetIgnoreDriveTypes(SettingsHelper.GetIgnoreTypes);
            _preferredPhone = SettingsHelper.GetPreferredPhone;
            if (!string.IsNullOrEmpty(_preferredPhone)) 
            {
                preferredPhoneComboBox.Items.Add("Toon alle telefoons");
                preferredPhoneComboBox.Items.Add("Mijn telefoon");
                preferredPhoneComboBox.SelectedIndex = 1;
            }
            if (SettingsHelper.DebugMode)
            {
                btnCopy.Visible = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            availablePhonesList.Items.Clear();
            _availableDrives.Clear();
            statusLabel.Text = "Start met zoeken...";
            try
            {
                _availableDrives = Connector.GetPhoneList();
                foreach (var drive in _availableDrives)
                {
                    var description = drive.DisplayName;
                    description = string.IsNullOrEmpty(description) ? drive.Type : description;
                    var itemIndex = availablePhonesList.Items.Add(description);
                    if (!string.IsNullOrEmpty(_preferredPhone) && drive.Id == _preferredPhone)
                    {
                        availablePhonesList.SelectedIndex = itemIndex;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Er is een fout opgetreden. Controleer je mobiel, haal hem uit de laptop en sluit hem nogmaals aan.");
            }
            statusLabel.Text = "Klaar met zoeken naar mobiel.";
        }

        private void radioWhatsapp_CheckedChanged(object sender, EventArgs e)
        {
            radioCamera.Checked = !radioWhatsapp.Checked;
        }

        private void radioCamera_CheckedChanged(object sender, EventArgs e)
        {
            radioWhatsapp.Checked = !radioCamera.Checked;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            var selectedPhoneIndex = availablePhonesList.SelectedIndex;
            if (!_availableDrives.Any() || selectedPhoneIndex == -1 || _availableDrives.Count() > selectedPhoneIndex+1)
            {
                MessageBox.Show("Selecteer eerst de aangesloten mobiele telefoon.");
                return;
            }
            var selectedPhone = _availableDrives[selectedPhoneIndex];
            var syncForm = new SyncForm();
            syncForm.SetPhoneItem(selectedPhone, radioCamera.Checked);
            syncForm.ShowDialog();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPhone = _availableDrives[availablePhonesList.SelectedIndex].Id;
                Clipboard.SetText(selectedPhone);
            }
            catch (Exception) { }
        }
    }
}
