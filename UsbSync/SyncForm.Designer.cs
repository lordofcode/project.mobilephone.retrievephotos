
namespace UsbSync
{
    partial class SyncForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.photoTree = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadingStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLoadFolders = new System.Windows.Forms.Button();
            this.previewBrowser = new System.Windows.Forms.WebBrowser();
            this.previewButton = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.removeTimer = new System.Windows.Forms.Timer(this.components);
            this.saveLocationTree = new System.Windows.Forms.TreeView();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.radioNoFilter = new System.Windows.Forms.RadioButton();
            this.radioFilter = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbMonthSelection = new System.Windows.Forms.ComboBox();
            this.btnPhotoImport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // photoTree
            // 
            this.photoTree.Location = new System.Drawing.Point(12, 12);
            this.photoTree.Name = "photoTree";
            this.photoTree.Size = new System.Drawing.Size(383, 337);
            this.photoTree.TabIndex = 0;
            this.photoTree.DoubleClick += new System.EventHandler(this.photoTree_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "syncFormStatusStrip";
            // 
            // loadingStatusLabel
            // 
            this.loadingStatusLabel.Name = "loadingStatusLabel";
            this.loadingStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.loadingStatusLabel.Text = "...";
            // 
            // btnLoadFolders
            // 
            this.btnLoadFolders.Location = new System.Drawing.Point(12, 436);
            this.btnLoadFolders.Name = "btnLoadFolders";
            this.btnLoadFolders.Size = new System.Drawing.Size(99, 23);
            this.btnLoadFolders.TabIndex = 2;
            this.btnLoadFolders.Text = "&Alle mappen";
            this.btnLoadFolders.UseVisualStyleBackColor = true;
            this.btnLoadFolders.Click += new System.EventHandler(this.btnLoadFolders_Click);
            // 
            // previewBrowser
            // 
            this.previewBrowser.Location = new System.Drawing.Point(401, 12);
            this.previewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewBrowser.Name = "previewBrowser";
            this.previewBrowser.ScrollBarsEnabled = false;
            this.previewBrowser.Size = new System.Drawing.Size(387, 257);
            this.previewBrowser.TabIndex = 4;
            this.previewBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(228, 436);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(98, 23);
            this.previewButton.TabIndex = 5;
            this.previewButton.Text = "&Toon voorbeeld";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Visible = false;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(332, 436);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(63, 23);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Kopieer";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // removeTimer
            // 
            this.removeTimer.Interval = 1000;
            this.removeTimer.Tick += new System.EventHandler(this.removeTimer_Tick);
            // 
            // saveLocationTree
            // 
            this.saveLocationTree.Location = new System.Drawing.Point(401, 275);
            this.saveLocationTree.Name = "saveLocationTree";
            this.saveLocationTree.Size = new System.Drawing.Size(387, 115);
            this.saveLocationTree.TabIndex = 7;
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(713, 396);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(75, 23);
            this.btnNewFolder.TabIndex = 8;
            this.btnNewFolder.Text = "&Nieuwe map";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // radioNoFilter
            // 
            this.radioNoFilter.AutoSize = true;
            this.radioNoFilter.Checked = true;
            this.radioNoFilter.Location = new System.Drawing.Point(12, 355);
            this.radioNoFilter.Name = "radioNoFilter";
            this.radioNoFilter.Size = new System.Drawing.Size(152, 17);
            this.radioNoFilter.TabIndex = 9;
            this.radioNoFilter.TabStop = true;
            this.radioNoFilter.Text = "Geen filter op afbeeldingen";
            this.radioNoFilter.UseVisualStyleBackColor = true;
            this.radioNoFilter.CheckedChanged += new System.EventHandler(this.radioNoFilter_CheckedChanged);
            // 
            // radioFilter
            // 
            this.radioFilter.AutoSize = true;
            this.radioFilter.Location = new System.Drawing.Point(217, 355);
            this.radioFilter.Name = "radioFilter";
            this.radioFilter.Size = new System.Drawing.Size(178, 17);
            this.radioFilter.TabIndex = 10;
            this.radioFilter.Text = "Mappen met afbeeldingen [rood]";
            this.radioFilter.UseVisualStyleBackColor = true;
            this.radioFilter.CheckedChanged += new System.EventHandler(this.radioFilter_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Alles Selecteren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Selectie opheffen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbMonthSelection
            // 
            this.cmbMonthSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonthSelection.FormattingEnabled = true;
            this.cmbMonthSelection.Location = new System.Drawing.Point(228, 396);
            this.cmbMonthSelection.Name = "cmbMonthSelection";
            this.cmbMonthSelection.Size = new System.Drawing.Size(167, 21);
            this.cmbMonthSelection.TabIndex = 13;
            this.cmbMonthSelection.SelectedIndexChanged += new System.EventHandler(this.cmbMonthSelection_SelectedIndexChanged);
            // 
            // btnPhotoImport
            // 
            this.btnPhotoImport.Location = new System.Drawing.Point(632, 436);
            this.btnPhotoImport.Name = "btnPhotoImport";
            this.btnPhotoImport.Size = new System.Drawing.Size(156, 23);
            this.btnPhotoImport.TabIndex = 14;
            this.btnPhotoImport.Text = "Zet foto\'s op computer";
            this.btnPhotoImport.UseVisualStyleBackColor = true;
            this.btnPhotoImport.Click += new System.EventHandler(this.btnPhotoImport_Click);
            // 
            // SyncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnPhotoImport);
            this.Controls.Add(this.cmbMonthSelection);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioFilter);
            this.Controls.Add(this.radioNoFilter);
            this.Controls.Add(this.btnNewFolder);
            this.Controls.Add(this.saveLocationTree);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.previewBrowser);
            this.Controls.Add(this.btnLoadFolders);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.photoTree);
            this.Name = "SyncForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecteer foto\'s / mappen";
            this.Load += new System.EventHandler(this.SyncForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView photoTree;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel loadingStatusLabel;
        private System.Windows.Forms.Button btnLoadFolders;
        private System.Windows.Forms.WebBrowser previewBrowser;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Timer removeTimer;
        private System.Windows.Forms.TreeView saveLocationTree;
        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.RadioButton radioNoFilter;
        private System.Windows.Forms.RadioButton radioFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbMonthSelection;
        private System.Windows.Forms.Button btnPhotoImport;
    }
}