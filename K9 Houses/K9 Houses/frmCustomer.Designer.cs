
namespace K9_Houses
{
    partial class frmCustomer
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
            this.tabCustomer = new System.Windows.Forms.TabControl();
            this.displayBackground = new System.Windows.Forms.TabPage();
            this.exitBtn = new System.Windows.Forms.Button();
            this.displayDelete = new System.Windows.Forms.Button();
            this.displayEdit = new System.Windows.Forms.Button();
            this.displayAdd = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.AddForm = new System.Windows.Forms.TabPage();
            this.editCustomer = new System.Windows.Forms.TextBox();
            this.lblAddCustNo = new System.Windows.Forms.Label();
            this.dogImage = new System.Windows.Forms.Button();
            this.cancelAdd = new System.Windows.Forms.Button();
            this.btnAddAdd = new System.Windows.Forms.Button();
            this.telNo = new System.Windows.Forms.Label();
            this.foreName = new System.Windows.Forms.Label();
            this.surName = new System.Windows.Forms.Label();
            this.streetName = new System.Windows.Forms.Label();
            this.town = new System.Windows.Forms.Label();
            this.county = new System.Windows.Forms.Label();
            this.postCode = new System.Windows.Forms.Label();
            this.titleName = new System.Windows.Forms.Label();
            this.customerNo = new System.Windows.Forms.Label();
            this.txtAddForename = new System.Windows.Forms.TextBox();
            this.txtAddStreet = new System.Windows.Forms.TextBox();
            this.txtAddTown = new System.Windows.Forms.TextBox();
            this.txtAddCounty = new System.Windows.Forms.TextBox();
            this.txtAddPostcode = new System.Windows.Forms.TextBox();
            this.txtAddTelNo = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.cmbAddTitle = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditForename = new System.Windows.Forms.TextBox();
            this.txtEditStreet = new System.Windows.Forms.TextBox();
            this.txtEditTown = new System.Windows.Forms.TextBox();
            this.txtEditCounty = new System.Windows.Forms.TextBox();
            this.txtEditPostcode = new System.Windows.Forms.TextBox();
            this.txtEditTelNo = new System.Windows.Forms.TextBox();
            this.txtEditSurname = new System.Windows.Forms.TextBox();
            this.cmbEditTitle = new System.Windows.Forms.ComboBox();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCustomer.SuspendLayout();
            this.displayBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.AddForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(80, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(573, 70);
            this.title.TabIndex = 0;
            this.title.Text = "K9 Houses";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.displayBackground);
            this.tabCustomer.Controls.Add(this.AddForm);
            this.tabCustomer.Controls.Add(this.tabPage2);
            this.tabCustomer.Location = new System.Drawing.Point(23, 111);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.SelectedIndex = 0;
            this.tabCustomer.Size = new System.Drawing.Size(704, 589);
            this.tabCustomer.TabIndex = 1;
            // 
            // displayBackground
            // 
            this.displayBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.displayBackground.Controls.Add(this.exitBtn);
            this.displayBackground.Controls.Add(this.displayDelete);
            this.displayBackground.Controls.Add(this.displayEdit);
            this.displayBackground.Controls.Add(this.displayAdd);
            this.displayBackground.Controls.Add(this.dgvCustomers);
            this.displayBackground.Location = new System.Drawing.Point(4, 22);
            this.displayBackground.Name = "displayBackground";
            this.displayBackground.Padding = new System.Windows.Forms.Padding(3);
            this.displayBackground.Size = new System.Drawing.Size(696, 563);
            this.displayBackground.TabIndex = 0;
            this.displayBackground.Text = "Display";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(570, 186);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 51);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // displayDelete
            // 
            this.displayDelete.BackColor = System.Drawing.Color.Red;
            this.displayDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDelete.Location = new System.Drawing.Point(570, 129);
            this.displayDelete.Name = "displayDelete";
            this.displayDelete.Size = new System.Drawing.Size(106, 51);
            this.displayDelete.TabIndex = 5;
            this.displayDelete.Text = "Delete";
            this.displayDelete.UseVisualStyleBackColor = false;
            // 
            // displayEdit
            // 
            this.displayEdit.BackColor = System.Drawing.Color.Lime;
            this.displayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEdit.Location = new System.Drawing.Point(570, 72);
            this.displayEdit.Name = "displayEdit";
            this.displayEdit.Size = new System.Drawing.Size(106, 51);
            this.displayEdit.TabIndex = 4;
            this.displayEdit.Text = "Edit";
            this.displayEdit.UseVisualStyleBackColor = false;
            // 
            // displayAdd
            // 
            this.displayAdd.BackColor = System.Drawing.Color.Lime;
            this.displayAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAdd.Location = new System.Drawing.Point(570, 15);
            this.displayAdd.Name = "displayAdd";
            this.displayAdd.Size = new System.Drawing.Size(106, 51);
            this.displayAdd.TabIndex = 3;
            this.displayAdd.Text = "Add";
            this.displayAdd.UseVisualStyleBackColor = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(15, 15);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(539, 525);
            this.dgvCustomers.TabIndex = 2;
            // 
            // AddForm
            // 
            this.AddForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddForm.Controls.Add(this.editCustomer);
            this.AddForm.Controls.Add(this.lblAddCustNo);
            this.AddForm.Controls.Add(this.dogImage);
            this.AddForm.Controls.Add(this.cancelAdd);
            this.AddForm.Controls.Add(this.btnAddAdd);
            this.AddForm.Controls.Add(this.telNo);
            this.AddForm.Controls.Add(this.foreName);
            this.AddForm.Controls.Add(this.surName);
            this.AddForm.Controls.Add(this.streetName);
            this.AddForm.Controls.Add(this.town);
            this.AddForm.Controls.Add(this.county);
            this.AddForm.Controls.Add(this.postCode);
            this.AddForm.Controls.Add(this.titleName);
            this.AddForm.Controls.Add(this.customerNo);
            this.AddForm.Controls.Add(this.txtAddForename);
            this.AddForm.Controls.Add(this.txtAddStreet);
            this.AddForm.Controls.Add(this.txtAddTown);
            this.AddForm.Controls.Add(this.txtAddCounty);
            this.AddForm.Controls.Add(this.txtAddPostcode);
            this.AddForm.Controls.Add(this.txtAddTelNo);
            this.AddForm.Controls.Add(this.txtAddSurname);
            this.AddForm.Controls.Add(this.cmbAddTitle);
            this.AddForm.Location = new System.Drawing.Point(4, 22);
            this.AddForm.Name = "AddForm";
            this.AddForm.Padding = new System.Windows.Forms.Padding(3);
            this.AddForm.Size = new System.Drawing.Size(696, 563);
            this.AddForm.TabIndex = 1;
            this.AddForm.Text = "Add";
            // 
            // editCustomer
            // 
            this.editCustomer.Location = new System.Drawing.Point(151, 44);
            this.editCustomer.Name = "editCustomer";
            this.editCustomer.Size = new System.Drawing.Size(327, 20);
            this.editCustomer.TabIndex = 22;
            // 
            // lblAddCustNo
            // 
            this.lblAddCustNo.AutoSize = true;
            this.lblAddCustNo.Location = new System.Drawing.Point(151, 28);
            this.lblAddCustNo.Name = "lblAddCustNo";
            this.lblAddCustNo.Size = new System.Drawing.Size(13, 13);
            this.lblAddCustNo.TabIndex = 21;
            this.lblAddCustNo.Text = "L";
            // 
            // dogImage
            // 
            this.dogImage.Image = global::K9_Houses.Properties.Resources.IrishWolfhound;
            this.dogImage.Location = new System.Drawing.Point(487, 212);
            this.dogImage.Name = "dogImage";
            this.dogImage.Size = new System.Drawing.Size(203, 383);
            this.dogImage.TabIndex = 20;
            this.dogImage.UseVisualStyleBackColor = true;
            // 
            // cancelAdd
            // 
            this.cancelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAdd.ForeColor = System.Drawing.Color.Blue;
            this.cancelAdd.Location = new System.Drawing.Point(538, 124);
            this.cancelAdd.Name = "cancelAdd";
            this.cancelAdd.Size = new System.Drawing.Size(120, 53);
            this.cancelAdd.TabIndex = 19;
            this.cancelAdd.Text = "Cancel";
            this.cancelAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddAdd
            // 
            this.btnAddAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAddAdd.Location = new System.Drawing.Point(538, 49);
            this.btnAddAdd.Name = "btnAddAdd";
            this.btnAddAdd.Size = new System.Drawing.Size(120, 53);
            this.btnAddAdd.TabIndex = 18;
            this.btnAddAdd.Text = "Add";
            this.btnAddAdd.UseVisualStyleBackColor = false;
            // 
            // telNo
            // 
            this.telNo.AutoSize = true;
            this.telNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telNo.Location = new System.Drawing.Point(31, 388);
            this.telNo.Name = "telNo";
            this.telNo.Size = new System.Drawing.Size(58, 18);
            this.telNo.TabIndex = 17;
            this.telNo.Text = "Tel No";
            // 
            // foreName
            // 
            this.foreName.AutoSize = true;
            this.foreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreName.Location = new System.Drawing.Point(31, 169);
            this.foreName.Name = "foreName";
            this.foreName.Size = new System.Drawing.Size(84, 18);
            this.foreName.TabIndex = 16;
            this.foreName.Text = "Forename";
            // 
            // surName
            // 
            this.surName.AutoSize = true;
            this.surName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surName.Location = new System.Drawing.Point(31, 124);
            this.surName.Name = "surName";
            this.surName.Size = new System.Drawing.Size(75, 18);
            this.surName.TabIndex = 15;
            this.surName.Text = "Surname";
            // 
            // streetName
            // 
            this.streetName.AutoSize = true;
            this.streetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetName.Location = new System.Drawing.Point(31, 212);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(53, 18);
            this.streetName.TabIndex = 14;
            this.streetName.Text = "Street";
            // 
            // town
            // 
            this.town.AutoSize = true;
            this.town.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.town.Location = new System.Drawing.Point(31, 252);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(49, 18);
            this.town.TabIndex = 13;
            this.town.Text = "Town";
            // 
            // county
            // 
            this.county.AutoSize = true;
            this.county.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.county.Location = new System.Drawing.Point(31, 299);
            this.county.Name = "county";
            this.county.Size = new System.Drawing.Size(61, 18);
            this.county.TabIndex = 12;
            this.county.Text = "County";
            // 
            // postCode
            // 
            this.postCode.AutoSize = true;
            this.postCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCode.Location = new System.Drawing.Point(31, 344);
            this.postCode.Name = "postCode";
            this.postCode.Size = new System.Drawing.Size(80, 18);
            this.postCode.TabIndex = 11;
            this.postCode.Text = "Postcode";
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleName.Location = new System.Drawing.Point(31, 84);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(40, 18);
            this.titleName.TabIndex = 10;
            this.titleName.Text = "Title";
            // 
            // customerNo
            // 
            this.customerNo.AutoSize = true;
            this.customerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNo.Location = new System.Drawing.Point(31, 44);
            this.customerNo.Name = "customerNo";
            this.customerNo.Size = new System.Drawing.Size(114, 18);
            this.customerNo.TabIndex = 9;
            this.customerNo.Text = "Customer No.";
            // 
            // txtAddForename
            // 
            this.txtAddForename.Location = new System.Drawing.Point(151, 167);
            this.txtAddForename.Name = "txtAddForename";
            this.txtAddForename.Size = new System.Drawing.Size(327, 20);
            this.txtAddForename.TabIndex = 8;
            // 
            // txtAddStreet
            // 
            this.txtAddStreet.Location = new System.Drawing.Point(151, 210);
            this.txtAddStreet.Name = "txtAddStreet";
            this.txtAddStreet.Size = new System.Drawing.Size(327, 20);
            this.txtAddStreet.TabIndex = 7;
            // 
            // txtAddTown
            // 
            this.txtAddTown.Location = new System.Drawing.Point(151, 253);
            this.txtAddTown.Name = "txtAddTown";
            this.txtAddTown.Size = new System.Drawing.Size(327, 20);
            this.txtAddTown.TabIndex = 6;
            // 
            // txtAddCounty
            // 
            this.txtAddCounty.Location = new System.Drawing.Point(151, 297);
            this.txtAddCounty.Name = "txtAddCounty";
            this.txtAddCounty.Size = new System.Drawing.Size(327, 20);
            this.txtAddCounty.TabIndex = 5;
            // 
            // txtAddPostcode
            // 
            this.txtAddPostcode.Location = new System.Drawing.Point(151, 342);
            this.txtAddPostcode.Name = "txtAddPostcode";
            this.txtAddPostcode.Size = new System.Drawing.Size(327, 20);
            this.txtAddPostcode.TabIndex = 4;
            // 
            // txtAddTelNo
            // 
            this.txtAddTelNo.Location = new System.Drawing.Point(151, 386);
            this.txtAddTelNo.Name = "txtAddTelNo";
            this.txtAddTelNo.Size = new System.Drawing.Size(327, 20);
            this.txtAddTelNo.TabIndex = 3;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(151, 124);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(327, 20);
            this.txtAddSurname.TabIndex = 2;
            // 
            // cmbAddTitle
            // 
            this.cmbAddTitle.FormattingEnabled = true;
            this.cmbAddTitle.Location = new System.Drawing.Point(151, 81);
            this.cmbAddTitle.Name = "cmbAddTitle";
            this.cmbAddTitle.Size = new System.Drawing.Size(157, 21);
            this.cmbAddTitle.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.lblEditCustomer);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnEditEdit);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtEditForename);
            this.tabPage2.Controls.Add(this.txtEditStreet);
            this.tabPage2.Controls.Add(this.txtEditTown);
            this.tabPage2.Controls.Add(this.txtEditCounty);
            this.tabPage2.Controls.Add(this.txtEditPostcode);
            this.tabPage2.Controls.Add(this.txtEditTelNo);
            this.tabPage2.Controls.Add(this.txtEditSurname);
            this.tabPage2.Controls.Add(this.cmbEditTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 563);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Edit";
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Location = new System.Drawing.Point(155, 54);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(13, 13);
            this.lblEditCustomer.TabIndex = 42;
            this.lblEditCustomer.Text = "L";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(535, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnEditEdit
            // 
            this.btnEditEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEditEdit.Location = new System.Drawing.Point(535, 49);
            this.btnEditEdit.Name = "btnEditEdit";
            this.btnEditEdit.Size = new System.Drawing.Size(120, 53);
            this.btnEditEdit.TabIndex = 40;
            this.btnEditEdit.Text = "Edit";
            this.btnEditEdit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tel No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Forename";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Town";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "County";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Postcode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Customer No.";
            // 
            // txtEditForename
            // 
            this.txtEditForename.Location = new System.Drawing.Point(155, 172);
            this.txtEditForename.Name = "txtEditForename";
            this.txtEditForename.Size = new System.Drawing.Size(327, 20);
            this.txtEditForename.TabIndex = 29;
            // 
            // txtEditStreet
            // 
            this.txtEditStreet.Location = new System.Drawing.Point(155, 215);
            this.txtEditStreet.Name = "txtEditStreet";
            this.txtEditStreet.Size = new System.Drawing.Size(327, 20);
            this.txtEditStreet.TabIndex = 28;
            // 
            // txtEditTown
            // 
            this.txtEditTown.Location = new System.Drawing.Point(155, 258);
            this.txtEditTown.Name = "txtEditTown";
            this.txtEditTown.Size = new System.Drawing.Size(327, 20);
            this.txtEditTown.TabIndex = 27;
            // 
            // txtEditCounty
            // 
            this.txtEditCounty.Location = new System.Drawing.Point(155, 302);
            this.txtEditCounty.Name = "txtEditCounty";
            this.txtEditCounty.Size = new System.Drawing.Size(327, 20);
            this.txtEditCounty.TabIndex = 26;
            // 
            // txtEditPostcode
            // 
            this.txtEditPostcode.Location = new System.Drawing.Point(155, 347);
            this.txtEditPostcode.Name = "txtEditPostcode";
            this.txtEditPostcode.Size = new System.Drawing.Size(327, 20);
            this.txtEditPostcode.TabIndex = 25;
            // 
            // txtEditTelNo
            // 
            this.txtEditTelNo.Location = new System.Drawing.Point(155, 391);
            this.txtEditTelNo.Name = "txtEditTelNo";
            this.txtEditTelNo.Size = new System.Drawing.Size(327, 20);
            this.txtEditTelNo.TabIndex = 24;
            // 
            // txtEditSurname
            // 
            this.txtEditSurname.Location = new System.Drawing.Point(155, 129);
            this.txtEditSurname.Name = "txtEditSurname";
            this.txtEditSurname.Size = new System.Drawing.Size(327, 20);
            this.txtEditSurname.TabIndex = 23;
            // 
            // cmbEditTitle
            // 
            this.cmbEditTitle.FormattingEnabled = true;
            this.cmbEditTitle.Location = new System.Drawing.Point(155, 86);
            this.cmbEditTitle.Name = "cmbEditTitle";
            this.cmbEditTitle.Size = new System.Drawing.Size(157, 21);
            this.cmbEditTitle.TabIndex = 22;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(819, 721);
            this.Controls.Add(this.tabCustomer);
            this.Controls.Add(this.title);
            this.Name = "frmCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCustomer_Load_1);
            this.tabCustomer.ResumeLayout(false);
            this.displayBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.AddForm.ResumeLayout(false);
            this.AddForm.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl tabCustomer;
        private System.Windows.Forms.TabPage displayBackground;
        private System.Windows.Forms.TabPage AddForm;
        private System.Windows.Forms.Button dogImage;
        private System.Windows.Forms.Button cancelAdd;
        private System.Windows.Forms.Button btnAddAdd;
        private System.Windows.Forms.Label telNo;
        private System.Windows.Forms.Label foreName;
        private System.Windows.Forms.Label surName;
        private System.Windows.Forms.Label streetName;
        private System.Windows.Forms.Label town;
        private System.Windows.Forms.Label county;
        private System.Windows.Forms.Label postCode;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Label customerNo;
        private System.Windows.Forms.TextBox txtAddForename;
        private System.Windows.Forms.TextBox txtAddStreet;
        private System.Windows.Forms.TextBox txtAddTown;
        private System.Windows.Forms.TextBox txtAddCounty;
        private System.Windows.Forms.TextBox txtAddPostcode;
        private System.Windows.Forms.TextBox txtAddTelNo;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.ComboBox cmbAddTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button displayDelete;
        private System.Windows.Forms.Button displayEdit;
        private System.Windows.Forms.Button displayAdd;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblAddCustNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditForename;
        private System.Windows.Forms.TextBox txtEditStreet;
        private System.Windows.Forms.TextBox txtEditTown;
        private System.Windows.Forms.TextBox txtEditCounty;
        private System.Windows.Forms.TextBox txtEditPostcode;
        private System.Windows.Forms.TextBox txtEditTelNo;
        private System.Windows.Forms.TextBox txtEditSurname;
        private System.Windows.Forms.ComboBox cmbEditTitle;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.TextBox editCustomer;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Button exitBtn;
    }
}

