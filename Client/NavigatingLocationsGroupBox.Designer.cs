namespace MyPhotosGUI
{
    partial class NavigatingLocationsGroupBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxLocationsLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLocationsLatitude = new System.Windows.Forms.TextBox();
            this.textBoxLocationsName = new System.Windows.Forms.TextBox();
            this.textBoxLocationsZipcode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxLocationsScenery = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLocationsLongitude
            // 
            this.textBoxLocationsLongitude.Enabled = false;
            this.textBoxLocationsLongitude.Location = new System.Drawing.Point(64, 71);
            this.textBoxLocationsLongitude.MaxLength = 13;
            this.textBoxLocationsLongitude.Name = "textBoxLocationsLongitude";
            this.textBoxLocationsLongitude.Size = new System.Drawing.Size(67, 20);
            this.textBoxLocationsLongitude.TabIndex = 28;
            // 
            // textBoxLocationsLatitude
            // 
            this.textBoxLocationsLatitude.Enabled = false;
            this.textBoxLocationsLatitude.Location = new System.Drawing.Point(191, 71);
            this.textBoxLocationsLatitude.MaxLength = 13;
            this.textBoxLocationsLatitude.Name = "textBoxLocationsLatitude";
            this.textBoxLocationsLatitude.Size = new System.Drawing.Size(83, 20);
            this.textBoxLocationsLatitude.TabIndex = 29;
            // 
            // textBoxLocationsName
            // 
            this.textBoxLocationsName.Enabled = false;
            this.textBoxLocationsName.Location = new System.Drawing.Point(64, 19);
            this.textBoxLocationsName.Name = "textBoxLocationsName";
            this.textBoxLocationsName.Size = new System.Drawing.Size(210, 20);
            this.textBoxLocationsName.TabIndex = 30;
            // 
            // textBoxLocationsZipcode
            // 
            this.textBoxLocationsZipcode.Enabled = false;
            this.textBoxLocationsZipcode.Location = new System.Drawing.Point(191, 46);
            this.textBoxLocationsZipcode.Name = "textBoxLocationsZipcode";
            this.textBoxLocationsZipcode.Size = new System.Drawing.Size(83, 20);
            this.textBoxLocationsZipcode.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(144, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Latitude:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(6, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Longitude:";
            // 
            // textBoxLocationsScenery
            // 
            this.textBoxLocationsScenery.Enabled = false;
            this.textBoxLocationsScenery.Location = new System.Drawing.Point(64, 46);
            this.textBoxLocationsScenery.Name = "textBoxLocationsScenery";
            this.textBoxLocationsScenery.Size = new System.Drawing.Size(67, 20);
            this.textBoxLocationsScenery.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(140, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Zip code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(15, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Scenery:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(26, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Name:";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox.Controls.Add(this.textBoxLocationsLongitude);
            this.groupBox.Controls.Add(this.buttonRemove);
            this.groupBox.Controls.Add(this.textBoxLocationsLatitude);
            this.groupBox.Controls.Add(this.buttonSave);
            this.groupBox.Controls.Add(this.textBoxLocationsName);
            this.groupBox.Controls.Add(this.textBoxLocationsZipcode);
            this.groupBox.Controls.Add(this.buttonNext);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.buttonNew);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.buttonPrev);
            this.groupBox.Controls.Add(this.textBoxLocationsScenery);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(289, 134);
            this.groupBox.TabIndex = 31;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "GroupBox (0/0)";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(64, 100);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(66, 24);
            this.buttonRemove.TabIndex = 26;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(136, 100);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(66, 24);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(36, 100);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(24, 24);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(208, 100);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(66, 24);
            this.buttonNew.TabIndex = 24;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(10, 100);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(24, 24);
            this.buttonPrev.TabIndex = 21;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NavigatingLocationsGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "NavigatingLocationsGroupBox";
            this.Size = new System.Drawing.Size(295, 141);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLocationsLongitude;
        private System.Windows.Forms.TextBox textBoxLocationsLatitude;
        private System.Windows.Forms.TextBox textBoxLocationsName;
        private System.Windows.Forms.TextBox textBoxLocationsZipcode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxLocationsScenery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
