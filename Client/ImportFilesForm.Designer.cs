namespace MyPhotosGUI
{
    partial class ImportFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFilesForm));
            this.groupBoxAdditionalLabels = new System.Windows.Forms.GroupBox();
            this.textBoxAdditionalLabels = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.comboBoxGeneralWeather = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateCreated = new System.Windows.Forms.DateTimePicker();
            this.textBoxGeneralEvent = new System.Windows.Forms.TextBox();
            this.textBoxGeneralDescription = new System.Windows.Forms.TextBox();
            this.textBoxGeneralName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.navigatingLocationsGroupBox = new MyPhotosGUI.NavigatingLocationsGroupBox();
            this.navigatingPeopleGroupBox = new MyPhotosGUI.NavigatingPeopleGroupBox();
            this.groupBoxAdditionalLabels.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdditionalLabels
            // 
            this.groupBoxAdditionalLabels.Controls.Add(this.textBoxAdditionalLabels);
            this.groupBoxAdditionalLabels.Controls.Add(this.label8);
            this.groupBoxAdditionalLabels.Location = new System.Drawing.Point(482, 457);
            this.groupBoxAdditionalLabels.Name = "groupBoxAdditionalLabels";
            this.groupBoxAdditionalLabels.Size = new System.Drawing.Size(288, 65);
            this.groupBoxAdditionalLabels.TabIndex = 9;
            this.groupBoxAdditionalLabels.TabStop = false;
            this.groupBoxAdditionalLabels.Text = "Additional Labels";
            // 
            // textBoxAdditionalLabels
            // 
            this.textBoxAdditionalLabels.Location = new System.Drawing.Point(60, 28);
            this.textBoxAdditionalLabels.Name = "textBoxAdditionalLabels";
            this.textBoxAdditionalLabels.Size = new System.Drawing.Size(214, 20);
            this.textBoxAdditionalLabels.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Labels:";
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.comboBoxGeneralWeather);
            this.groupBoxGeneral.Controls.Add(this.dateTimePickerDateCreated);
            this.groupBoxGeneral.Controls.Add(this.textBoxGeneralEvent);
            this.groupBoxGeneral.Controls.Add(this.textBoxGeneralDescription);
            this.groupBoxGeneral.Controls.Add(this.textBoxGeneralName);
            this.groupBoxGeneral.Controls.Add(this.label7);
            this.groupBoxGeneral.Controls.Add(this.label4);
            this.groupBoxGeneral.Controls.Add(this.label3);
            this.groupBoxGeneral.Controls.Add(this.label2);
            this.groupBoxGeneral.Controls.Add(this.label1);
            this.groupBoxGeneral.Location = new System.Drawing.Point(485, 12);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(288, 159);
            this.groupBoxGeneral.TabIndex = 6;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // comboBoxGeneralWeather
            // 
            this.comboBoxGeneralWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGeneralWeather.FormattingEnabled = true;
            this.comboBoxGeneralWeather.Location = new System.Drawing.Point(85, 77);
            this.comboBoxGeneralWeather.Name = "comboBoxGeneralWeather";
            this.comboBoxGeneralWeather.Size = new System.Drawing.Size(189, 21);
            this.comboBoxGeneralWeather.Sorted = true;
            this.comboBoxGeneralWeather.TabIndex = 13;
            // 
            // dateTimePickerDateCreated
            // 
            this.dateTimePickerDateCreated.Location = new System.Drawing.Point(85, 130);
            this.dateTimePickerDateCreated.Name = "dateTimePickerDateCreated";
            this.dateTimePickerDateCreated.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerDateCreated.TabIndex = 12;
            // 
            // textBoxGeneralEvent
            // 
            this.textBoxGeneralEvent.Location = new System.Drawing.Point(85, 104);
            this.textBoxGeneralEvent.Name = "textBoxGeneralEvent";
            this.textBoxGeneralEvent.Size = new System.Drawing.Size(189, 20);
            this.textBoxGeneralEvent.TabIndex = 11;
            // 
            // textBoxGeneralDescription
            // 
            this.textBoxGeneralDescription.Location = new System.Drawing.Point(85, 51);
            this.textBoxGeneralDescription.Name = "textBoxGeneralDescription";
            this.textBoxGeneralDescription.Size = new System.Drawing.Size(189, 20);
            this.textBoxGeneralDescription.TabIndex = 9;
            // 
            // textBoxGeneralName
            // 
            this.textBoxGeneralName.Location = new System.Drawing.Point(85, 25);
            this.textBoxGeneralName.Name = "textBoxGeneralName";
            this.textBoxGeneralName.ReadOnly = true;
            this.textBoxGeneralName.Size = new System.Drawing.Size(189, 20);
            this.textBoxGeneralName.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weather:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date created:";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxMain.Location = new System.Drawing.Point(6, 17);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(452, 452);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 12;
            this.pictureBoxMain.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 493);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 28);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Location = new System.Drawing.Point(98, 493);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(80, 28);
            this.buttonSkip.TabIndex = 17;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.axWindowsMediaPlayer);
            this.groupBoxPreview.Controls.Add(this.pictureBoxMain);
            this.groupBoxPreview.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(464, 475);
            this.groupBoxPreview.TabIndex = 19;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(6, 17);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(452, 452);
            this.axWindowsMediaPlayer.TabIndex = 20;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // navigatingLocationsGroupBox
            // 
            this.navigatingLocationsGroupBox.Location = new System.Drawing.Point(482, 173);
            this.navigatingLocationsGroupBox.Name = "navigatingLocationsGroupBox";
            this.navigatingLocationsGroupBox.Size = new System.Drawing.Size(295, 141);
            this.navigatingLocationsGroupBox.TabIndex = 20;
            // 
            // navigatingPeopleGroupBox
            // 
            this.navigatingPeopleGroupBox.Location = new System.Drawing.Point(482, 310);
            this.navigatingPeopleGroupBox.Name = "navigatingPeopleGroupBox";
            this.navigatingPeopleGroupBox.PictureBoxMain = null;
            this.navigatingPeopleGroupBox.Size = new System.Drawing.Size(295, 141);
            this.navigatingPeopleGroupBox.TabIndex = 21;
            // 
            // ImportFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.navigatingPeopleGroupBox);
            this.Controls.Add(this.navigatingLocationsGroupBox);
            this.Controls.Add(this.groupBoxPreview);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxAdditionalLabels);
            this.Controls.Add(this.groupBoxGeneral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportFilesForm";
            this.Text = "Import File(s)";
            this.groupBoxAdditionalLabels.ResumeLayout(false);
            this.groupBoxAdditionalLabels.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBoxPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.GroupBox groupBoxAdditionalLabels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TextBox textBoxAdditionalLabels;
        private System.Windows.Forms.TextBox textBoxGeneralDescription;
        private System.Windows.Forms.TextBox textBoxGeneralEvent;
        private System.Windows.Forms.TextBox textBoxGeneralName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreated;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.ComboBox comboBoxGeneralWeather;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private NavigatingPeopleGroupBox navigatingPeopleGroupBox;
        private NavigatingLocationsGroupBox navigatingLocationsGroupBox;
    }
}