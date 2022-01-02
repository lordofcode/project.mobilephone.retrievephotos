
namespace UsbSync
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.preferredPhoneComboBox = new System.Windows.Forms.ComboBox();
            this.availablePhonesList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioWhatsapp = new System.Windows.Forms.RadioButton();
            this.radioCamera = new System.Windows.Forms.RadioButton();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.statusSummary = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sluit je mobiel aan en druk op Start...";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(342, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "&Start...";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopy);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.preferredPhoneComboBox);
            this.groupBox2.Controls.Add(this.availablePhonesList);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beschikbare telefoon(s)";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(7, 34);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(120, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "kopieer";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kies voorkeur:";
            // 
            // preferredPhoneComboBox
            // 
            this.preferredPhoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.preferredPhoneComboBox.FormattingEnabled = true;
            this.preferredPhoneComboBox.Location = new System.Drawing.Point(342, 19);
            this.preferredPhoneComboBox.Name = "preferredPhoneComboBox";
            this.preferredPhoneComboBox.Size = new System.Drawing.Size(428, 21);
            this.preferredPhoneComboBox.TabIndex = 1;
            // 
            // availablePhonesList
            // 
            this.availablePhonesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availablePhonesList.FormattingEnabled = true;
            this.availablePhonesList.Location = new System.Drawing.Point(6, 63);
            this.availablePhonesList.Name = "availablePhonesList";
            this.availablePhonesList.Size = new System.Drawing.Size(764, 21);
            this.availablePhonesList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioWhatsapp);
            this.groupBox3.Controls.Add(this.radioCamera);
            this.groupBox3.Location = new System.Drawing.Point(12, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ophalen";
            // 
            // radioWhatsapp
            // 
            this.radioWhatsapp.AutoSize = true;
            this.radioWhatsapp.Location = new System.Drawing.Point(342, 33);
            this.radioWhatsapp.Name = "radioWhatsapp";
            this.radioWhatsapp.Size = new System.Drawing.Size(105, 17);
            this.radioWhatsapp.TabIndex = 1;
            this.radioWhatsapp.Text = "Foto\'s Whatsapp";
            this.radioWhatsapp.UseVisualStyleBackColor = true;
            this.radioWhatsapp.CheckedChanged += new System.EventHandler(this.radioWhatsapp_CheckedChanged);
            // 
            // radioCamera
            // 
            this.radioCamera.AutoSize = true;
            this.radioCamera.Checked = true;
            this.radioCamera.Location = new System.Drawing.Point(6, 33);
            this.radioCamera.Name = "radioCamera";
            this.radioCamera.Size = new System.Drawing.Size(91, 17);
            this.radioCamera.TabIndex = 0;
            this.radioCamera.TabStop = true;
            this.radioCamera.Text = "Foto\'s camera";
            this.radioCamera.UseVisualStyleBackColor = true;
            this.radioCamera.CheckedChanged += new System.EventHandler(this.radioCamera_CheckedChanged);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(354, 277);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(75, 23);
            this.btnNextStep.TabIndex = 3;
            this.btnNextStep.Text = "Volgende stap...";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // statusSummary
            // 
            this.statusSummary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusSummary.Location = new System.Drawing.Point(0, 310);
            this.statusSummary.Name = "statusSummary";
            this.statusSummary.Size = new System.Drawing.Size(800, 22);
            this.statusSummary.TabIndex = 4;
            this.statusSummary.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(16, 17);
            this.statusLabel.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.statusSummary);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto\'s camera en whatsapp op pc zetten";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusSummary.ResumeLayout(false);
            this.statusSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox availablePhonesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox preferredPhoneComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioWhatsapp;
        private System.Windows.Forms.RadioButton radioCamera;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.StatusStrip statusSummary;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button btnCopy;
    }
}

