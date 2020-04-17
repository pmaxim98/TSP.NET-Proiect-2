namespace MyPhotosGUI
{
    partial class NavigatingPeopleGroupBox
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
            this.textBoxPeopleAge = new System.Windows.Forms.TextBox();
            this.textBoxPeopleLastName = new System.Windows.Forms.TextBox();
            this.pictureBoxPerson = new System.Windows.Forms.PictureBox();
            this.textBoxPeopleFirstName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPeopleAge
            // 
            this.textBoxPeopleAge.Enabled = false;
            this.textBoxPeopleAge.Location = new System.Drawing.Point(69, 71);
            this.textBoxPeopleAge.MaxLength = 3;
            this.textBoxPeopleAge.Name = "textBoxPeopleAge";
            this.textBoxPeopleAge.Size = new System.Drawing.Size(127, 20);
            this.textBoxPeopleAge.TabIndex = 30;
            // 
            // textBoxPeopleLastName
            // 
            this.textBoxPeopleLastName.Enabled = false;
            this.textBoxPeopleLastName.Location = new System.Drawing.Point(69, 45);
            this.textBoxPeopleLastName.Name = "textBoxPeopleLastName";
            this.textBoxPeopleLastName.Size = new System.Drawing.Size(127, 20);
            this.textBoxPeopleLastName.TabIndex = 29;
            // 
            // pictureBoxPerson
            // 
            this.pictureBoxPerson.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPerson.Location = new System.Drawing.Point(202, 19);
            this.pictureBoxPerson.Name = "pictureBoxPerson";
            this.pictureBoxPerson.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerson.TabIndex = 27;
            this.pictureBoxPerson.TabStop = false;
            this.pictureBoxPerson.Click += new System.EventHandler(this.pictureBoxPerson_Click);
            // 
            // textBoxPeopleFirstName
            // 
            this.textBoxPeopleFirstName.Enabled = false;
            this.textBoxPeopleFirstName.Location = new System.Drawing.Point(69, 19);
            this.textBoxPeopleFirstName.Name = "textBoxPeopleFirstName";
            this.textBoxPeopleFirstName.Size = new System.Drawing.Size(127, 20);
            this.textBoxPeopleFirstName.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(37, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Age:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(7, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Last name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "First name:";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox.Controls.Add(this.textBoxPeopleAge);
            this.groupBox.Controls.Add(this.buttonRemove);
            this.groupBox.Controls.Add(this.textBoxPeopleLastName);
            this.groupBox.Controls.Add(this.buttonSave);
            this.groupBox.Controls.Add(this.pictureBoxPerson);
            this.groupBox.Controls.Add(this.textBoxPeopleFirstName);
            this.groupBox.Controls.Add(this.buttonNext);
            this.groupBox.Controls.Add(this.label16);
            this.groupBox.Controls.Add(this.buttonNew);
            this.groupBox.Controls.Add(this.label15);
            this.groupBox.Controls.Add(this.buttonPrev);
            this.groupBox.Controls.Add(this.label14);
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
            // NavigatingPeopleGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "NavigatingPeopleGroupBox";
            this.Size = new System.Drawing.Size(295, 141);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerson)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPeopleAge;
        private System.Windows.Forms.TextBox textBoxPeopleLastName;
        private System.Windows.Forms.PictureBox pictureBoxPerson;
        private System.Windows.Forms.TextBox textBoxPeopleFirstName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
