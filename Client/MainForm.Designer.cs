namespace MyPhotosGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listView = new System.Windows.Forms.ListView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonImportRecursive = new System.Windows.Forms.Button();
            this.buttonImportFolders = new System.Windows.Forms.Button();
            this.buttonImportFiles = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.comboBoxSearchCriteria = new System.Windows.Forms.ComboBox();
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.navigatingPeopleGroupBox = new MyPhotosGUI.NavigatingPeopleGroupBox();
            this.navigatingLocationsGroupBox = new MyPhotosGUI.NavigatingLocationsGroupBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBoxAdditionalLabels.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxExport.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxMain);
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multimedia";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(8, 19);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(450, 450);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(8, 19);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(450, 450);
            this.axWindowsMediaPlayer.TabIndex = 3;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // listView
            // 
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 45);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(460, 407);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(285, 20);
            this.textBoxSearch.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonImportRecursive);
            this.groupBox6.Controls.Add(this.buttonImportFolders);
            this.groupBox6.Controls.Add(this.buttonImportFiles);
            this.groupBox6.Location = new System.Drawing.Point(771, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 48);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Import";
            // 
            // buttonImportRecursive
            // 
            this.buttonImportRecursive.Location = new System.Drawing.Point(200, 19);
            this.buttonImportRecursive.Name = "buttonImportRecursive";
            this.buttonImportRecursive.Size = new System.Drawing.Size(85, 23);
            this.buttonImportRecursive.TabIndex = 2;
            this.buttonImportRecursive.Text = "Recursive";
            this.buttonImportRecursive.UseVisualStyleBackColor = true;
            this.buttonImportRecursive.Click += new System.EventHandler(this.buttonImportRecursive_Click);
            // 
            // buttonImportFolders
            // 
            this.buttonImportFolders.Location = new System.Drawing.Point(103, 19);
            this.buttonImportFolders.Name = "buttonImportFolders";
            this.buttonImportFolders.Size = new System.Drawing.Size(91, 23);
            this.buttonImportFolders.TabIndex = 1;
            this.buttonImportFolders.Text = "Folder(s)";
            this.buttonImportFolders.UseVisualStyleBackColor = true;
            this.buttonImportFolders.Click += new System.EventHandler(this.buttonImportFolders_Click);
            // 
            // buttonImportFiles
            // 
            this.buttonImportFiles.Location = new System.Drawing.Point(6, 19);
            this.buttonImportFiles.Name = "buttonImportFiles";
            this.buttonImportFiles.Size = new System.Drawing.Size(91, 23);
            this.buttonImportFiles.TabIndex = 0;
            this.buttonImportFiles.Text = "File(s)";
            this.buttonImportFiles.UseVisualStyleBackColor = true;
            this.buttonImportFiles.Click += new System.EventHandler(this.buttonImportFiles_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(391, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = resources.GetString("openFileDialog.Filter");
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Open file(s)";
            // 
            // groupBoxAdditionalLabels
            // 
            this.groupBoxAdditionalLabels.Controls.Add(this.textBoxAdditionalLabels);
            this.groupBoxAdditionalLabels.Controls.Add(this.label8);
            this.groupBoxAdditionalLabels.Location = new System.Drawing.Point(477, 450);
            this.groupBoxAdditionalLabels.Name = "groupBoxAdditionalLabels";
            this.groupBoxAdditionalLabels.Size = new System.Drawing.Size(288, 65);
            this.groupBoxAdditionalLabels.TabIndex = 13;
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
            this.groupBoxGeneral.Location = new System.Drawing.Point(477, 3);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(288, 161);
            this.groupBoxGeneral.TabIndex = 10;
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
            // comboBoxSearchCriteria
            // 
            this.comboBoxSearchCriteria.FormattingEnabled = true;
            this.comboBoxSearchCriteria.Location = new System.Drawing.Point(297, 18);
            this.comboBoxSearchCriteria.Name = "comboBoxSearchCriteria";
            this.comboBoxSearchCriteria.Size = new System.Drawing.Size(88, 21);
            this.comboBoxSearchCriteria.TabIndex = 14;
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Controls.Add(this.buttonRemove);
            this.groupBoxExport.Controls.Add(this.buttonPrint);
            this.groupBoxExport.Location = new System.Drawing.Point(1068, 3);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Size = new System.Drawing.Size(175, 48);
            this.groupBoxExport.TabIndex = 16;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Export";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(94, 18);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(6, 18);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.comboBoxSearchCriteria);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Location = new System.Drawing.Point(771, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 458);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(4, 492);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSave.Size = new System.Drawing.Size(467, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // navigatingPeopleGroupBox
            // 
            this.navigatingPeopleGroupBox.Location = new System.Drawing.Point(473, 311);
            this.navigatingPeopleGroupBox.Name = "navigatingPeopleGroupBox";
            this.navigatingPeopleGroupBox.PictureBoxMain = null;
            this.navigatingPeopleGroupBox.Size = new System.Drawing.Size(294, 141);
            this.navigatingPeopleGroupBox.TabIndex = 19;
            // 
            // navigatingLocationsGroupBox
            // 
            this.navigatingLocationsGroupBox.Location = new System.Drawing.Point(473, 165);
            this.navigatingLocationsGroupBox.Name = "navigatingLocationsGroupBox";
            this.navigatingLocationsGroupBox.Size = new System.Drawing.Size(298, 140);
            this.navigatingLocationsGroupBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1255, 520);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.navigatingPeopleGroupBox);
            this.Controls.Add(this.navigatingLocationsGroupBox);
            this.Controls.Add(this.groupBoxExport);
            this.Controls.Add(this.groupBoxAdditionalLabels);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MyPhotos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBoxAdditionalLabels.ResumeLayout(false);
            this.groupBoxAdditionalLabels.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxExport.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonImportRecursive;
        private System.Windows.Forms.Button buttonImportFolders;
        private System.Windows.Forms.Button buttonImportFiles;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBoxAdditionalLabels;
        private System.Windows.Forms.TextBox textBoxAdditionalLabels;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.ComboBox comboBoxGeneralWeather;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreated;
        private System.Windows.Forms.TextBox textBoxGeneralEvent;
        private System.Windows.Forms.TextBox textBoxGeneralDescription;
        private System.Windows.Forms.TextBox textBoxGeneralName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearchCriteria;
        private System.Windows.Forms.GroupBox groupBoxExport;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private NavigatingLocationsGroupBox navigatingLocationsGroupBox;
        private NavigatingPeopleGroupBox navigatingPeopleGroupBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}

