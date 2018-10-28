﻿namespace GenealoTree
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthMonthTextBox = new System.Windows.Forms.TextBox();
            this.birthDayTextBox = new System.Windows.Forms.TextBox();
            this.birthYearTextBox = new System.Windows.Forms.TextBox();
            this.birthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.birthCertificateTextBox = new System.Windows.Forms.TextBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.deathYearTextBox = new System.Windows.Forms.TextBox();
            this.deathDayTextBox = new System.Windows.Forms.TextBox();
            this.deathMonthTextBox = new System.Windows.Forms.TextBox();
            this.deathPlaceTextBox = new System.Windows.Forms.TextBox();
            this.deathCertificateTextBox = new System.Windows.Forms.TextBox();
            this.causeOfDeathTextBox = new System.Windows.Forms.TextBox();
            this.burialYearTextBox = new System.Windows.Forms.TextBox();
            this.burialDayTextBox = new System.Windows.Forms.TextBox();
            this.burialMonthTextBox = new System.Windows.Forms.TextBox();
            this.burialPlaceTextBox = new System.Windows.Forms.TextBox();
            this.cemetaryTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.militaryServiceTextBox = new System.Windows.Forms.TextBox();
            this.professionTextBox = new System.Windows.Forms.TextBox();
            this.naSexRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.questionBox.SuspendLayout();
            this.notes.SuspendLayout();
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
            this.questionBox.Controls.Add(this.questionTextBox);
            this.questionBox.Location = new System.Drawing.Point(252, 442);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(200, 180);
            this.questionBox.TabIndex = 49;
            this.questionBox.TabStop = false;
            this.questionBox.Text = "Questions:";
            // 
            // notes
            // 
            this.notes.Controls.Add(this.notesTextBox);
            this.notes.Location = new System.Drawing.Point(21, 323);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(200, 299);
            this.notes.TabIndex = 48;
            this.notes.TabStop = false;
            this.notes.Text = "Notes:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.professionTextBox);
            this.groupBox3.Controls.Add(this.militaryServiceTextBox);
            this.groupBox3.Controls.Add(this.ssnTextBox);
            this.groupBox3.Controls.Add(this.ssn);
            this.groupBox3.Controls.Add(this.profession);
            this.groupBox3.Controls.Add(this.militaryService);
            this.groupBox3.Location = new System.Drawing.Point(21, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 92);
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
            this.profession.Location = new System.Drawing.Point(6, 63);
            this.profession.Name = "profession";
            this.profession.Size = new System.Drawing.Size(59, 13);
            this.profession.TabIndex = 26;
            this.profession.Text = "Profession:";
            // 
            // militaryService
            // 
            this.militaryService.AutoSize = true;
            this.militaryService.Location = new System.Drawing.Point(6, 40);
            this.militaryService.Name = "militaryService";
            this.militaryService.Size = new System.Drawing.Size(81, 13);
            this.militaryService.TabIndex = 4;
            this.militaryService.Text = "Military Service:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cemetaryTextBox);
            this.groupBox2.Controls.Add(this.burialPlaceTextBox);
            this.groupBox2.Controls.Add(this.burialYearTextBox);
            this.groupBox2.Controls.Add(this.burialDate);
            this.groupBox2.Controls.Add(this.burialDayTextBox);
            this.groupBox2.Controls.Add(this.burialMonthTextBox);
            this.groupBox2.Controls.Add(this.burialCemetary);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.burialPlace);
            this.groupBox2.Location = new System.Drawing.Point(252, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 89);
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
            // burialCemetary
            // 
            this.burialCemetary.AutoSize = true;
            this.burialCemetary.Location = new System.Drawing.Point(6, 62);
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
            this.burialPlace.Location = new System.Drawing.Point(6, 41);
            this.burialPlace.Name = "burialPlace";
            this.burialPlace.Size = new System.Drawing.Size(37, 13);
            this.burialPlace.TabIndex = 4;
            this.burialPlace.Text = "Place:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.causeOfDeathTextBox);
            this.groupBox1.Controls.Add(this.deathCertificateTextBox);
            this.groupBox1.Controls.Add(this.deathPlaceTextBox);
            this.groupBox1.Controls.Add(this.deathYearTextBox);
            this.groupBox1.Controls.Add(this.deathDayTextBox);
            this.groupBox1.Controls.Add(this.deathMonthTextBox);
            this.groupBox1.Controls.Add(this.deathDate);
            this.groupBox1.Controls.Add(this.deathCertificate);
            this.groupBox1.Controls.Add(this.causeOfDeath);
            this.groupBox1.Controls.Add(this.deathPlace);
            this.groupBox1.Location = new System.Drawing.Point(252, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 116);
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
            this.deathCertificate.Location = new System.Drawing.Point(6, 66);
            this.deathCertificate.Name = "deathCertificate";
            this.deathCertificate.Size = new System.Drawing.Size(89, 13);
            this.deathCertificate.TabIndex = 26;
            this.deathCertificate.Text = "Death Certificate:";
            // 
            // causeOfDeath
            // 
            this.causeOfDeath.AutoSize = true;
            this.causeOfDeath.Location = new System.Drawing.Point(7, 91);
            this.causeOfDeath.Name = "causeOfDeath";
            this.causeOfDeath.Size = new System.Drawing.Size(84, 13);
            this.causeOfDeath.TabIndex = 25;
            this.causeOfDeath.Text = "Cause of Death:";
            // 
            // deathPlace
            // 
            this.deathPlace.AutoSize = true;
            this.deathPlace.Location = new System.Drawing.Point(6, 42);
            this.deathPlace.Name = "deathPlace";
            this.deathPlace.Size = new System.Drawing.Size(37, 13);
            this.deathPlace.TabIndex = 4;
            this.deathPlace.Text = "Place:";
            // 
            // birthGroupBox
            // 
            this.birthGroupBox.Controls.Add(this.naSexRadioButton);
            this.birthGroupBox.Controls.Add(this.femaleRadioButton);
            this.birthGroupBox.Controls.Add(this.maleRadioButton);
            this.birthGroupBox.Controls.Add(this.birthCertificateTextBox);
            this.birthGroupBox.Controls.Add(this.birthPlaceTextBox);
            this.birthGroupBox.Controls.Add(this.birthYearTextBox);
            this.birthGroupBox.Controls.Add(this.birthDayTextBox);
            this.birthGroupBox.Controls.Add(this.birthMonthTextBox);
            this.birthGroupBox.Controls.Add(this.birthDate);
            this.birthGroupBox.Controls.Add(this.birthCertificate);
            this.birthGroupBox.Controls.Add(this.birthPlace);
            this.birthGroupBox.Controls.Add(this.sex);
            this.birthGroupBox.Location = new System.Drawing.Point(252, 105);
            this.birthGroupBox.Name = "birthGroupBox";
            this.birthGroupBox.Size = new System.Drawing.Size(200, 114);
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
            this.birthCertificate.Location = new System.Drawing.Point(6, 60);
            this.birthCertificate.Name = "birthCertificate";
            this.birthCertificate.Size = new System.Drawing.Size(81, 13);
            this.birthCertificate.TabIndex = 26;
            this.birthCertificate.Text = "Birth Certificate:";
            // 
            // birthPlace
            // 
            this.birthPlace.AutoSize = true;
            this.birthPlace.Location = new System.Drawing.Point(6, 38);
            this.birthPlace.Name = "birthPlace";
            this.birthPlace.Size = new System.Drawing.Size(37, 13);
            this.birthPlace.TabIndex = 4;
            this.birthPlace.Text = "Place:";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(7, 82);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(28, 13);
            this.sex.TabIndex = 3;
            this.sex.Text = "Sex:";
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.lastNameTextBox);
            this.nameGroupBox.Controls.Add(this.middleNameTextBox);
            this.nameGroupBox.Controls.Add(this.firstNameTextBox);
            this.nameGroupBox.Controls.Add(this.firstName);
            this.nameGroupBox.Controls.Add(this.middleName);
            this.nameGroupBox.Controls.Add(this.lastName);
            this.nameGroupBox.Location = new System.Drawing.Point(252, 9);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(200, 90);
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
            this.middleName.Location = new System.Drawing.Point(6, 40);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(41, 13);
            this.middleName.TabIndex = 9;
            this.middleName.Text = "Middle:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(7, 64);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(30, 13);
            this.lastName.TabIndex = 1;
            this.lastName.Text = "Last:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(41, 13);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(53, 37);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.middleNameTextBox.TabIndex = 11;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(43, 61);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // birthMonthTextBox
            // 
            this.birthMonthTextBox.Location = new System.Drawing.Point(45, 13);
            this.birthMonthTextBox.Name = "birthMonthTextBox";
            this.birthMonthTextBox.Size = new System.Drawing.Size(29, 20);
            this.birthMonthTextBox.TabIndex = 27;
            // 
            // birthDayTextBox
            // 
            this.birthDayTextBox.Location = new System.Drawing.Point(80, 13);
            this.birthDayTextBox.Name = "birthDayTextBox";
            this.birthDayTextBox.Size = new System.Drawing.Size(29, 20);
            this.birthDayTextBox.TabIndex = 28;
            // 
            // birthYearTextBox
            // 
            this.birthYearTextBox.Location = new System.Drawing.Point(115, 13);
            this.birthYearTextBox.Name = "birthYearTextBox";
            this.birthYearTextBox.Size = new System.Drawing.Size(57, 20);
            this.birthYearTextBox.TabIndex = 29;
            // 
            // birthPlaceTextBox
            // 
            this.birthPlaceTextBox.Location = new System.Drawing.Point(45, 35);
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            this.birthPlaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthPlaceTextBox.TabIndex = 30;
            // 
            // birthCertificateTextBox
            // 
            this.birthCertificateTextBox.Location = new System.Drawing.Point(93, 57);
            this.birthCertificateTextBox.Name = "birthCertificateTextBox";
            this.birthCertificateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthCertificateTextBox.TabIndex = 31;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(35, 82);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 32;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(82, 82);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 33;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // deathYearTextBox
            // 
            this.deathYearTextBox.Location = new System.Drawing.Point(115, 13);
            this.deathYearTextBox.Name = "deathYearTextBox";
            this.deathYearTextBox.Size = new System.Drawing.Size(57, 20);
            this.deathYearTextBox.TabIndex = 32;
            // 
            // deathDayTextBox
            // 
            this.deathDayTextBox.Location = new System.Drawing.Point(80, 13);
            this.deathDayTextBox.Name = "deathDayTextBox";
            this.deathDayTextBox.Size = new System.Drawing.Size(29, 20);
            this.deathDayTextBox.TabIndex = 31;
            // 
            // deathMonthTextBox
            // 
            this.deathMonthTextBox.Location = new System.Drawing.Point(45, 13);
            this.deathMonthTextBox.Name = "deathMonthTextBox";
            this.deathMonthTextBox.Size = new System.Drawing.Size(29, 20);
            this.deathMonthTextBox.TabIndex = 30;
            // 
            // deathPlaceTextBox
            // 
            this.deathPlaceTextBox.Location = new System.Drawing.Point(51, 40);
            this.deathPlaceTextBox.Name = "deathPlaceTextBox";
            this.deathPlaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.deathPlaceTextBox.TabIndex = 33;
            // 
            // deathCertificateTextBox
            // 
            this.deathCertificateTextBox.Location = new System.Drawing.Point(94, 63);
            this.deathCertificateTextBox.Name = "deathCertificateTextBox";
            this.deathCertificateTextBox.Size = new System.Drawing.Size(100, 20);
            this.deathCertificateTextBox.TabIndex = 34;
            // 
            // causeOfDeathTextBox
            // 
            this.causeOfDeathTextBox.Location = new System.Drawing.Point(92, 88);
            this.causeOfDeathTextBox.Name = "causeOfDeathTextBox";
            this.causeOfDeathTextBox.Size = new System.Drawing.Size(100, 20);
            this.causeOfDeathTextBox.TabIndex = 35;
            // 
            // burialYearTextBox
            // 
            this.burialYearTextBox.Location = new System.Drawing.Point(115, 13);
            this.burialYearTextBox.Name = "burialYearTextBox";
            this.burialYearTextBox.Size = new System.Drawing.Size(57, 20);
            this.burialYearTextBox.TabIndex = 38;
            // 
            // burialDayTextBox
            // 
            this.burialDayTextBox.Location = new System.Drawing.Point(80, 13);
            this.burialDayTextBox.Name = "burialDayTextBox";
            this.burialDayTextBox.Size = new System.Drawing.Size(29, 20);
            this.burialDayTextBox.TabIndex = 37;
            // 
            // burialMonthTextBox
            // 
            this.burialMonthTextBox.Location = new System.Drawing.Point(45, 13);
            this.burialMonthTextBox.Name = "burialMonthTextBox";
            this.burialMonthTextBox.Size = new System.Drawing.Size(29, 20);
            this.burialMonthTextBox.TabIndex = 36;
            // 
            // burialPlaceTextBox
            // 
            this.burialPlaceTextBox.Location = new System.Drawing.Point(50, 37);
            this.burialPlaceTextBox.Name = "burialPlaceTextBox";
            this.burialPlaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.burialPlaceTextBox.TabIndex = 39;
            // 
            // cemetaryTextBox
            // 
            this.cemetaryTextBox.Location = new System.Drawing.Point(97, 59);
            this.cemetaryTextBox.Name = "cemetaryTextBox";
            this.cemetaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.cemetaryTextBox.TabIndex = 40;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(10, 19);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(184, 155);
            this.questionTextBox.TabIndex = 0;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(6, 19);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(184, 274);
            this.notesTextBox.TabIndex = 1;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(44, 13);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(100, 20);
            this.ssnTextBox.TabIndex = 27;
            // 
            // militaryServiceTextBox
            // 
            this.militaryServiceTextBox.Location = new System.Drawing.Point(93, 37);
            this.militaryServiceTextBox.Name = "militaryServiceTextBox";
            this.militaryServiceTextBox.Size = new System.Drawing.Size(100, 20);
            this.militaryServiceTextBox.TabIndex = 28;
            // 
            // professionTextBox
            // 
            this.professionTextBox.Location = new System.Drawing.Point(71, 60);
            this.professionTextBox.Name = "professionTextBox";
            this.professionTextBox.Size = new System.Drawing.Size(100, 20);
            this.professionTextBox.TabIndex = 29;
            // 
            // naSexRadioButton
            // 
            this.naSexRadioButton.AutoSize = true;
            this.naSexRadioButton.Checked = true;
            this.naSexRadioButton.Location = new System.Drawing.Point(140, 82);
            this.naSexRadioButton.Name = "naSexRadioButton";
            this.naSexRadioButton.Size = new System.Drawing.Size(45, 17);
            this.naSexRadioButton.TabIndex = 34;
            this.naSexRadioButton.TabStop = true;
            this.naSexRadioButton.Text = "N/A";
            this.naSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(114, 633);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 23);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(252, 633);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 52;
            this.cancelButton.Text = "Cancel Edit";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 668);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
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
            this.questionBox.ResumeLayout(false);
            this.questionBox.PerformLayout();
            this.notes.ResumeLayout(false);
            this.notes.PerformLayout();
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
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox professionTextBox;
        private System.Windows.Forms.TextBox militaryServiceTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox cemetaryTextBox;
        private System.Windows.Forms.TextBox burialPlaceTextBox;
        private System.Windows.Forms.TextBox burialYearTextBox;
        private System.Windows.Forms.TextBox burialDayTextBox;
        private System.Windows.Forms.TextBox burialMonthTextBox;
        private System.Windows.Forms.TextBox causeOfDeathTextBox;
        private System.Windows.Forms.TextBox deathCertificateTextBox;
        private System.Windows.Forms.TextBox deathPlaceTextBox;
        private System.Windows.Forms.TextBox deathYearTextBox;
        private System.Windows.Forms.TextBox deathDayTextBox;
        private System.Windows.Forms.TextBox deathMonthTextBox;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.TextBox birthCertificateTextBox;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.TextBox birthYearTextBox;
        private System.Windows.Forms.TextBox birthDayTextBox;
        private System.Windows.Forms.TextBox birthMonthTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.RadioButton naSexRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}