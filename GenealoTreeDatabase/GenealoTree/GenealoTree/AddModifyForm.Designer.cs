namespace GenealoTree
{
    partial class AddModifyForm
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
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.questionBox = new System.Windows.Forms.GroupBox();
            this.notes = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ssn = new System.Windows.Forms.Label();
            this.profession = new System.Windows.Forms.Label();
            this.militaryService = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.burialDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.burialCemetary = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.burialPlace = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deathDate = new System.Windows.Forms.Label();
            this.deathCertificate = new System.Windows.Forms.Label();
            this.causeOfDeath = new System.Windows.Forms.Label();
            this.deathPlace = new System.Windows.Forms.Label();
            this.birthGroupBox = new System.Windows.Forms.GroupBox();
            this.birthDate = new System.Windows.Forms.Label();
            this.birthCertificate = new System.Windows.Forms.Label();
            this.birthPlace = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.firstName = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.birthGroupBox.SuspendLayout();
            this.nameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(21, 9);
            this.profilePictureBox.MaximumSize = new System.Drawing.Size(200, 210);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(200, 210);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 50;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(252, 393);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(200, 180);
            this.questionBox.TabIndex = 49;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Questions:";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(21, 331);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(200, 242);
            this.notes.TabIndex = 48;
            this.notes.TabStop = false;
            this.notes.Text = "Notes:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ssn);
            this.groupBox3.Controls.Add(this.profession);
            this.groupBox3.Controls.Add(this.militaryService);
            this.groupBox3.Location = new System.Drawing.Point(21, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Information:";
            // 
            // ssn
            // 
            this.ssn.AutoSize = true;
            this.ssn.Location = new System.Drawing.Point(6, 16);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(32, 13);
            this.ssn.TabIndex = 13;
            this.ssn.Text = "SSN:";
            // 
            // profession
            // 
            this.profession.AutoSize = true;
            this.profession.Location = new System.Drawing.Point(6, 42);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(59, 13);
            this.profession.TabIndex = 26;
            this.profession.Text = "Profession:";
            // 
            // militaryService
            // 
            this.militaryService.AutoSize = true;
            this.militaryService.Location = new System.Drawing.Point(6, 29);
            this.militaryService.Name = "militaryService";
            this.militaryService.Size = new System.Drawing.Size(78, 13);
            this.militaryService.TabIndex = 4;
            this.militaryService.Text = "Military Service";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.burialDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.burialCemetary);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.burialPlace);
            this.groupBox2.Location = new System.Drawing.Point(252, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Burial:";
            // 
            // burialDate
            // 
            this.burialDate.AutoSize = true;
            this.burialDate.Location = new System.Drawing.Point(6, 16);
            this.burialDate.Name = "burialDate";
            this.burialDate.Size = new System.Drawing.Size(33, 13);
            this.burialDate.TabIndex = 13;
            this.burialDate.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "                    ";
            // 
            // burialCemetary
            // 
            this.burialCemetary.AutoSize = true;
            this.burialCemetary.Location = new System.Drawing.Point(6, 42);
            this.burialCemetary.Name = "burialCemetary";
            this.burialCemetary.Size = new System.Drawing.Size(85, 13);
            this.burialCemetary.TabIndex = 26;
            this.burialCemetary.Text = "Cemetary Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "                   ";
            // 
            // burialPlace
            // 
            this.burialPlace.AutoSize = true;
            this.burialPlace.Location = new System.Drawing.Point(6, 29);
            this.burialPlace.Name = "burialPlace";
            this.burialPlace.Size = new System.Drawing.Size(37, 13);
            this.burialPlace.TabIndex = 4;
            this.burialPlace.Text = "Place:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deathDate);
            this.groupBox1.Controls.Add(this.deathCertificate);
            this.groupBox1.Controls.Add(this.causeOfDeath);
            this.groupBox1.Controls.Add(this.deathPlace);
            this.groupBox1.Location = new System.Drawing.Point(252, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Death:";
            // 
            // deathDate
            // 
            this.deathDate.AutoSize = true;
            this.deathDate.Location = new System.Drawing.Point(6, 16);
            this.deathDate.Name = "deathDate";
            this.deathDate.Size = new System.Drawing.Size(33, 13);
            this.deathDate.TabIndex = 13;
            this.deathDate.Text = "Date:";
            // 
            // deathCertificate
            // 
            this.deathCertificate.AutoSize = true;
            this.deathCertificate.Location = new System.Drawing.Point(6, 42);
            this.deathCertificate.Name = "deathCertificate";
            this.deathCertificate.Size = new System.Drawing.Size(89, 13);
            this.deathCertificate.TabIndex = 26;
            this.deathCertificate.Text = "Death Certificate:";
            // 
            // causeOfDeath
            // 
            this.causeOfDeath.AutoSize = true;
            this.causeOfDeath.Location = new System.Drawing.Point(6, 55);
            this.causeOfDeath.Name = "causeOfDeath";
            this.causeOfDeath.Size = new System.Drawing.Size(84, 13);
            this.causeOfDeath.TabIndex = 25;
            this.causeOfDeath.Text = "Cause of Death:";
            // 
            // deathPlace
            // 
            this.deathPlace.AutoSize = true;
            this.deathPlace.Location = new System.Drawing.Point(6, 29);
            this.deathPlace.Name = "deathPlace";
            this.deathPlace.Size = new System.Drawing.Size(37, 13);
            this.deathPlace.TabIndex = 4;
            this.deathPlace.Text = "Place:";
            // 
            // birthGroupBox
            // 
            this.birthGroupBox.Controls.Add(this.birthDate);
            this.birthGroupBox.Controls.Add(this.birthCertificate);
            this.birthGroupBox.Controls.Add(this.birthPlace);
            this.birthGroupBox.Controls.Add(this.sex);
            this.birthGroupBox.Location = new System.Drawing.Point(252, 75);
            this.birthGroupBox.Name = "birthGroupBox";
            this.birthGroupBox.Size = new System.Drawing.Size(200, 100);
            this.birthGroupBox.TabIndex = 44;
            this.birthGroupBox.TabStop = false;
            this.birthGroupBox.Text = "Birth:";
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Location = new System.Drawing.Point(6, 16);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(33, 13);
            this.birthDate.TabIndex = 13;
            this.birthDate.Text = "Date:";
            // 
            // birthCertificate
            // 
            this.birthCertificate.AutoSize = true;
            this.birthCertificate.Location = new System.Drawing.Point(6, 42);
            this.birthCertificate.Name = "birthCertificate";
            this.birthCertificate.Size = new System.Drawing.Size(81, 13);
            this.birthCertificate.TabIndex = 26;
            this.birthCertificate.Text = "Birth Certificate:";
            // 
            // birthPlace
            // 
            this.birthPlace.AutoSize = true;
            this.birthPlace.Location = new System.Drawing.Point(6, 29);
            this.birthPlace.Name = "birthPlace";
            this.birthPlace.Size = new System.Drawing.Size(37, 13);
            this.birthPlace.TabIndex = 4;
            this.birthPlace.Text = "Place:";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(6, 55);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(28, 13);
            this.sex.TabIndex = 3;
            this.sex.Text = "Sex:";
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.firstName);
            this.nameGroupBox.Controls.Add(this.middleName);
            this.nameGroupBox.Controls.Add(this.lastName);
            this.nameGroupBox.Location = new System.Drawing.Point(252, 9);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(200, 60);
            this.nameGroupBox.TabIndex = 43;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(6, 16);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(29, 13);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First:";
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Location = new System.Drawing.Point(6, 29);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(41, 13);
            this.middleName.TabIndex = 9;
            this.middleName.Text = "Middle:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(6, 42);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(30, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last:";
            // 
            // AddModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 664);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.birthGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.Name = "AddModifyForm";
            this.Text = "Add/Modify Personal Information";
            this.Load += new System.EventHandler(this.AddModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.birthGroupBox.ResumeLayout(false);
            this.birthGroupBox.PerformLayout();
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.GroupBox questionBox;
        private System.Windows.Forms.GroupBox notes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ssn;
        private System.Windows.Forms.Label profession;
        private System.Windows.Forms.Label militaryService;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label burialDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label burialCemetary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label burialPlace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label deathDate;
        private System.Windows.Forms.Label deathCertificate;
        private System.Windows.Forms.Label causeOfDeath;
        private System.Windows.Forms.Label deathPlace;
        private System.Windows.Forms.GroupBox birthGroupBox;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.Label birthCertificate;
        private System.Windows.Forms.Label birthPlace;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.GroupBox nameGroupBox;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label lastName;
    }
}