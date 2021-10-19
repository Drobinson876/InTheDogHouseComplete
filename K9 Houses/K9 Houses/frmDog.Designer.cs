
namespace K9_Houses
{
    partial class frmDog
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
            this.title = new System.Windows.Forms.Label();
            this.tabDog = new System.Windows.Forms.TabControl();
            this.dogDisplay = new System.Windows.Forms.TabPage();
            this.exitDogBtn = new System.Windows.Forms.Button();
            this.dogDisplayDelete = new System.Windows.Forms.Button();
            this.dogDisplayEdit = new System.Windows.Forms.Button();
            this.dogDisplayAdd = new System.Windows.Forms.Button();
            this.dgvDogs = new System.Windows.Forms.DataGridView();
            this.AddForm = new System.Windows.Forms.TabPage();
            this.cmbAddCustNo = new System.Windows.Forms.ComboBox();
            this.cmbAddBreedNo = new System.Windows.Forms.ComboBox();
            this.dtpAddDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbAddGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dogColour = new System.Windows.Forms.TextBox();
            this.dogNo = new System.Windows.Forms.TextBox();
            this.lblAddDogNo = new System.Windows.Forms.Label();
            this.dogCancel = new System.Windows.Forms.Button();
            this.dogAddAdd = new System.Windows.Forms.Button();
            this.dateOfBirthDog = new System.Windows.Forms.Label();
            this.dogName = new System.Windows.Forms.Label();
            this.customerNo = new System.Windows.Forms.Label();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.dogImage = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editDtpDog = new System.Windows.Forms.DateTimePicker();
            this.editGenderCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editColour = new System.Windows.Forms.TextBox();
            this.editDogNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.editDogName = new System.Windows.Forms.TextBox();
            this.dogCancelCancel = new System.Windows.Forms.Button();
            this.dogEditEdit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.editBreedNo = new System.Windows.Forms.ComboBox();
            this.editCustNo = new System.Windows.Forms.ComboBox();
            this.tabDog.SuspendLayout();
            this.dogDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).BeginInit();
            this.AddForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(105, -113);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(573, 70);
            this.title.TabIndex = 2;
            this.title.Text = "K9 Houses";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDog
            // 
            this.tabDog.Controls.Add(this.dogDisplay);
            this.tabDog.Controls.Add(this.AddForm);
            this.tabDog.Controls.Add(this.tabPage2);
            this.tabDog.Location = new System.Drawing.Point(61, 77);
            this.tabDog.Name = "tabDog";
            this.tabDog.SelectedIndex = 0;
            this.tabDog.Size = new System.Drawing.Size(704, 589);
            this.tabDog.TabIndex = 4;
            // 
            // dogDisplay
            // 
            this.dogDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dogDisplay.Controls.Add(this.exitDogBtn);
            this.dogDisplay.Controls.Add(this.dogDisplayDelete);
            this.dogDisplay.Controls.Add(this.dogDisplayEdit);
            this.dogDisplay.Controls.Add(this.dogDisplayAdd);
            this.dogDisplay.Controls.Add(this.dgvDogs);
            this.dogDisplay.Location = new System.Drawing.Point(4, 22);
            this.dogDisplay.Name = "dogDisplay";
            this.dogDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.dogDisplay.Size = new System.Drawing.Size(696, 563);
            this.dogDisplay.TabIndex = 0;
            this.dogDisplay.Text = "Display";
            // 
            // exitDogBtn
            // 
            this.exitDogBtn.BackColor = System.Drawing.Color.Red;
            this.exitDogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitDogBtn.Location = new System.Drawing.Point(570, 186);
            this.exitDogBtn.Name = "exitDogBtn";
            this.exitDogBtn.Size = new System.Drawing.Size(106, 51);
            this.exitDogBtn.TabIndex = 6;
            this.exitDogBtn.Text = "Exit";
            this.exitDogBtn.UseVisualStyleBackColor = false;
            this.exitDogBtn.Click += new System.EventHandler(this.exitDogBtn_Click_1);
            // 
            // dogDisplayDelete
            // 
            this.dogDisplayDelete.BackColor = System.Drawing.Color.Red;
            this.dogDisplayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogDisplayDelete.Location = new System.Drawing.Point(570, 129);
            this.dogDisplayDelete.Name = "dogDisplayDelete";
            this.dogDisplayDelete.Size = new System.Drawing.Size(106, 51);
            this.dogDisplayDelete.TabIndex = 5;
            this.dogDisplayDelete.Text = "Delete";
            this.dogDisplayDelete.UseVisualStyleBackColor = false;
            this.dogDisplayDelete.Click += new System.EventHandler(this.dogDisplayDelete_Click);
            // 
            // dogDisplayEdit
            // 
            this.dogDisplayEdit.BackColor = System.Drawing.Color.Lime;
            this.dogDisplayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogDisplayEdit.Location = new System.Drawing.Point(570, 72);
            this.dogDisplayEdit.Name = "dogDisplayEdit";
            this.dogDisplayEdit.Size = new System.Drawing.Size(106, 51);
            this.dogDisplayEdit.TabIndex = 4;
            this.dogDisplayEdit.Text = "Edit";
            this.dogDisplayEdit.UseVisualStyleBackColor = false;
            this.dogDisplayEdit.Click += new System.EventHandler(this.dogDisplayEdit_Click);
            // 
            // dogDisplayAdd
            // 
            this.dogDisplayAdd.BackColor = System.Drawing.Color.Lime;
            this.dogDisplayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogDisplayAdd.Location = new System.Drawing.Point(570, 15);
            this.dogDisplayAdd.Name = "dogDisplayAdd";
            this.dogDisplayAdd.Size = new System.Drawing.Size(106, 51);
            this.dogDisplayAdd.TabIndex = 3;
            this.dogDisplayAdd.Text = "Add";
            this.dogDisplayAdd.UseVisualStyleBackColor = false;
            // 
            // dgvDogs
            // 
            this.dgvDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogs.Location = new System.Drawing.Point(15, 15);
            this.dgvDogs.Name = "dgvDogs";
            this.dgvDogs.Size = new System.Drawing.Size(539, 525);
            this.dgvDogs.TabIndex = 2;
            // 
            // AddForm
            // 
            this.AddForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddForm.Controls.Add(this.cmbAddCustNo);
            this.AddForm.Controls.Add(this.cmbAddBreedNo);
            this.AddForm.Controls.Add(this.dtpAddDOB);
            this.AddForm.Controls.Add(this.cmbAddGender);
            this.AddForm.Controls.Add(this.lblGender);
            this.AddForm.Controls.Add(this.lblColour);
            this.AddForm.Controls.Add(this.lblCustomer);
            this.AddForm.Controls.Add(this.label4);
            this.AddForm.Controls.Add(this.dogColour);
            this.AddForm.Controls.Add(this.dogNo);
            this.AddForm.Controls.Add(this.lblAddDogNo);
            this.AddForm.Controls.Add(this.dogCancel);
            this.AddForm.Controls.Add(this.dogAddAdd);
            this.AddForm.Controls.Add(this.dateOfBirthDog);
            this.AddForm.Controls.Add(this.dogName);
            this.AddForm.Controls.Add(this.customerNo);
            this.AddForm.Controls.Add(this.txtDogName);
            this.AddForm.Controls.Add(this.dogImage);
            this.AddForm.Location = new System.Drawing.Point(4, 22);
            this.AddForm.Name = "AddForm";
            this.AddForm.Padding = new System.Windows.Forms.Padding(3);
            this.AddForm.Size = new System.Drawing.Size(696, 563);
            this.AddForm.TabIndex = 1;
            this.AddForm.Text = "Add";
            // 
            // cmbAddCustNo
            // 
            this.cmbAddCustNo.FormattingEnabled = true;
            this.cmbAddCustNo.Location = new System.Drawing.Point(151, 283);
            this.cmbAddCustNo.Name = "cmbAddCustNo";
            this.cmbAddCustNo.Size = new System.Drawing.Size(171, 21);
            this.cmbAddCustNo.TabIndex = 54;
            // 
            // cmbAddBreedNo
            // 
            this.cmbAddBreedNo.FormattingEnabled = true;
            this.cmbAddBreedNo.Location = new System.Drawing.Point(151, 124);
            this.cmbAddBreedNo.Name = "cmbAddBreedNo";
            this.cmbAddBreedNo.Size = new System.Drawing.Size(171, 21);
            this.cmbAddBreedNo.TabIndex = 53;
            // 
            // dtpAddDOB
            // 
            this.dtpAddDOB.Location = new System.Drawing.Point(151, 167);
            this.dtpAddDOB.Name = "dtpAddDOB";
            this.dtpAddDOB.Size = new System.Drawing.Size(195, 20);
            this.dtpAddDOB.TabIndex = 52;
            // 
            // cmbAddGender
            // 
            this.cmbAddGender.FormattingEnabled = true;
            this.cmbAddGender.Location = new System.Drawing.Point(151, 208);
            this.cmbAddGender.Name = "cmbAddGender";
            this.cmbAddGender.Size = new System.Drawing.Size(52, 21);
            this.cmbAddGender.TabIndex = 51;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(31, 208);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 18);
            this.lblGender.TabIndex = 50;
            this.lblGender.Text = "Gender";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColour.Location = new System.Drawing.Point(31, 247);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(59, 18);
            this.lblColour.TabIndex = 49;
            this.lblColour.Text = "Colour";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(31, 282);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(109, 18);
            this.lblCustomer.TabIndex = 48;
            this.lblCustomer.Text = "Customer No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Dog No";
            // 
            // dogColour
            // 
            this.dogColour.Location = new System.Drawing.Point(151, 245);
            this.dogColour.Name = "dogColour";
            this.dogColour.Size = new System.Drawing.Size(327, 20);
            this.dogColour.TabIndex = 44;
            // 
            // dogNo
            // 
            this.dogNo.Location = new System.Drawing.Point(151, 44);
            this.dogNo.Name = "dogNo";
            this.dogNo.Size = new System.Drawing.Size(218, 20);
            this.dogNo.TabIndex = 22;
            // 
            // lblAddDogNo
            // 
            this.lblAddDogNo.AutoSize = true;
            this.lblAddDogNo.Location = new System.Drawing.Point(151, 28);
            this.lblAddDogNo.Name = "lblAddDogNo";
            this.lblAddDogNo.Size = new System.Drawing.Size(13, 13);
            this.lblAddDogNo.TabIndex = 21;
            this.lblAddDogNo.Text = "L";
            // 
            // dogCancel
            // 
            this.dogCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogCancel.ForeColor = System.Drawing.Color.Blue;
            this.dogCancel.Location = new System.Drawing.Point(538, 108);
            this.dogCancel.Name = "dogCancel";
            this.dogCancel.Size = new System.Drawing.Size(120, 53);
            this.dogCancel.TabIndex = 19;
            this.dogCancel.Text = "Cancel";
            this.dogCancel.UseVisualStyleBackColor = false;
            // 
            // dogAddAdd
            // 
            this.dogAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogAddAdd.ForeColor = System.Drawing.Color.Blue;
            this.dogAddAdd.Location = new System.Drawing.Point(538, 28);
            this.dogAddAdd.Name = "dogAddAdd";
            this.dogAddAdd.Size = new System.Drawing.Size(120, 53);
            this.dogAddAdd.TabIndex = 18;
            this.dogAddAdd.Text = "Add";
            this.dogAddAdd.UseVisualStyleBackColor = false;
            this.dogAddAdd.Click += new System.EventHandler(this.dogAddAdd_Click);
            // 
            // dateOfBirthDog
            // 
            this.dateOfBirthDog.AutoSize = true;
            this.dateOfBirthDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDog.Location = new System.Drawing.Point(31, 166);
            this.dateOfBirthDog.Name = "dateOfBirthDog";
            this.dateOfBirthDog.Size = new System.Drawing.Size(54, 18);
            this.dateOfBirthDog.TabIndex = 16;
            this.dateOfBirthDog.Text = "D.O.B";
            // 
            // dogName
            // 
            this.dogName.AutoSize = true;
            this.dogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogName.Location = new System.Drawing.Point(31, 84);
            this.dogName.Name = "dogName";
            this.dogName.Size = new System.Drawing.Size(88, 18);
            this.dogName.TabIndex = 15;
            this.dogName.Text = "Dog Name";
            // 
            // customerNo
            // 
            this.customerNo.AutoSize = true;
            this.customerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNo.Location = new System.Drawing.Point(31, 127);
            this.customerNo.Name = "customerNo";
            this.customerNo.Size = new System.Drawing.Size(79, 18);
            this.customerNo.TabIndex = 9;
            this.customerNo.Text = "Breed No";
            // 
            // txtDogName
            // 
            this.txtDogName.Location = new System.Drawing.Point(151, 85);
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(327, 20);
            this.txtDogName.TabIndex = 2;
            // 
            // dogImage
            // 
            this.dogImage.Image = global::K9_Houses.Properties.Resources.IrishWolfhound;
            this.dogImage.Location = new System.Drawing.Point(487, 167);
            this.dogImage.Name = "dogImage";
            this.dogImage.Size = new System.Drawing.Size(203, 383);
            this.dogImage.TabIndex = 20;
            this.dogImage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.editCustNo);
            this.tabPage2.Controls.Add(this.editBreedNo);
            this.tabPage2.Controls.Add(this.editDtpDog);
            this.tabPage2.Controls.Add(this.editGenderCmb);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.editColour);
            this.tabPage2.Controls.Add(this.editDogNo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.editDogName);
            this.tabPage2.Controls.Add(this.dogCancelCancel);
            this.tabPage2.Controls.Add(this.dogEditEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 563);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Edit";
            // 
            // editDtpDog
            // 
            this.editDtpDog.Location = new System.Drawing.Point(157, 163);
            this.editDtpDog.Name = "editDtpDog";
            this.editDtpDog.Size = new System.Drawing.Size(185, 20);
            this.editDtpDog.TabIndex = 67;
            // 
            // editGenderCmb
            // 
            this.editGenderCmb.FormattingEnabled = true;
            this.editGenderCmb.Location = new System.Drawing.Point(157, 205);
            this.editGenderCmb.Name = "editGenderCmb";
            this.editGenderCmb.Size = new System.Drawing.Size(52, 21);
            this.editGenderCmb.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Colour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Customer No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Dog No";
            // 
            // editColour
            // 
            this.editColour.Location = new System.Drawing.Point(157, 242);
            this.editColour.Name = "editColour";
            this.editColour.Size = new System.Drawing.Size(327, 20);
            this.editColour.TabIndex = 60;
            // 
            // editDogNo
            // 
            this.editDogNo.Location = new System.Drawing.Point(157, 41);
            this.editDogNo.Name = "editDogNo";
            this.editDogNo.Size = new System.Drawing.Size(218, 20);
            this.editDogNo.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "D.O.B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 55;
            this.label8.Text = "Dog Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "Breed No";
            // 
            // editDogName
            // 
            this.editDogName.Location = new System.Drawing.Point(157, 82);
            this.editDogName.Name = "editDogName";
            this.editDogName.Size = new System.Drawing.Size(327, 20);
            this.editDogName.TabIndex = 52;
            // 
            // dogCancelCancel
            // 
            this.dogCancelCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogCancelCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogCancelCancel.ForeColor = System.Drawing.Color.Blue;
            this.dogCancelCancel.Location = new System.Drawing.Point(535, 124);
            this.dogCancelCancel.Name = "dogCancelCancel";
            this.dogCancelCancel.Size = new System.Drawing.Size(120, 53);
            this.dogCancelCancel.TabIndex = 41;
            this.dogCancelCancel.Text = "Cancel";
            this.dogCancelCancel.UseVisualStyleBackColor = false;
            // 
            // dogEditEdit
            // 
            this.dogEditEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dogEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogEditEdit.ForeColor = System.Drawing.Color.Blue;
            this.dogEditEdit.Location = new System.Drawing.Point(535, 49);
            this.dogEditEdit.Name = "dogEditEdit";
            this.dogEditEdit.Size = new System.Drawing.Size(120, 53);
            this.dogEditEdit.TabIndex = 40;
            this.dogEditEdit.Text = "Edit";
            this.dogEditEdit.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(118, -10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(573, 70);
            this.label11.TabIndex = 3;
            this.label11.Text = "K9 Houses";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // editBreedNo
            // 
            this.editBreedNo.FormattingEnabled = true;
            this.editBreedNo.Location = new System.Drawing.Point(157, 121);
            this.editBreedNo.Name = "editBreedNo";
            this.editBreedNo.Size = new System.Drawing.Size(171, 21);
            this.editBreedNo.TabIndex = 68;
            // 
            // editCustNo
            // 
            this.editCustNo.FormattingEnabled = true;
            this.editCustNo.Location = new System.Drawing.Point(157, 280);
            this.editCustNo.Name = "editCustNo";
            this.editCustNo.Size = new System.Drawing.Size(327, 21);
            this.editCustNo.TabIndex = 69;
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(826, 657);
            this.Controls.Add(this.tabDog);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.title);
            this.Name = "frmDog";
            this.Text = "frmDog";
            this.tabDog.ResumeLayout(false);
            this.dogDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogs)).EndInit();
            this.AddForm.ResumeLayout(false);
            this.AddForm.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl tabDog;
        private System.Windows.Forms.TabPage dogDisplay;
        private System.Windows.Forms.Button dogDisplayDelete;
        private System.Windows.Forms.Button dogDisplayEdit;
        private System.Windows.Forms.Button dogDisplayAdd;
        private System.Windows.Forms.DataGridView dgvDogs;
        private System.Windows.Forms.TabPage AddForm;
        private System.Windows.Forms.TextBox dogNo;
        private System.Windows.Forms.Label lblAddDogNo;
        private System.Windows.Forms.Button dogCancel;
        private System.Windows.Forms.Button dogAddAdd;
        private System.Windows.Forms.Label dateOfBirthDog;
        private System.Windows.Forms.Label dogName;
        private System.Windows.Forms.Label customerNo;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.Button dogImage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button dogCancelCancel;
        private System.Windows.Forms.Button dogEditEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button exitDogBtn;
        private System.Windows.Forms.TextBox dogColour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAddGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox editGenderCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editColour;
        private System.Windows.Forms.TextBox editDogNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox editDogName;
        private System.Windows.Forms.DateTimePicker dtpAddDOB;
        private System.Windows.Forms.DateTimePicker editDtpDog;
        private System.Windows.Forms.ComboBox cmbAddCustNo;
        private System.Windows.Forms.ComboBox cmbAddBreedNo;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.ComboBox editBreedNo;
        private System.Windows.Forms.ComboBox editCustNo;
    }
}