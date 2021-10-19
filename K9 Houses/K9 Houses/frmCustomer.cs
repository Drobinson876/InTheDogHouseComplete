using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace K9_Houses

{
    public partial class frmCustomer : Form
    {
        SqlDataAdapter daCustomer;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBCustomer;
        DataRow drCustomer;
        String connStr, sqlCustomer;

        int selectedTab = 0;
        bool custSelected = false;
        int custNoSelected = 0;



        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load_1(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = InTheDoghouse; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            dgvCustomers.DataSource = dsInTheDogHouse.Tables["Customer"];

            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            tabCustomer.SelectedIndex = 1;
            tabCustomer.SelectedIndex = 0;
        }


        private void btnAddAdd_Click(object sender, EventArgs e)
        {

        }
        void voidClearAddForm()
        {
            cmbAddTitle.SelectedIndex = -1;
            txtAddForename.Clear();
            txtAddSurname.Clear();
            txtAddStreet.Clear();
            txtAddTown.Clear();
            txtAddCounty.Clear();
            txtAddPostcode.Clear();
            txtAddTelNo.Clear();
        }

        private void getNumber(int noRows)
        {
            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows[noRows - 1];
            lblAddCustNo.Text = (int.Parse(drCustomer["CustomerNo"].ToString()) + 1).ToString();
        }

        private void btnEditEdit_Click(object sender, EventArgs e)
        {

            if (editCustomer.Text == "Edit")
            {
                cmbEditTitle.Enabled = true;
                txtEditSurname.Enabled = true;
                txtEditSurname.Enabled = true;
                txtEditStreet.Enabled = true;
                txtEditTown.Enabled = true;
                txtEditCounty.Enabled = true;
                txtEditPostcode.Enabled = true;
                txtEditTelNo.Enabled = true;

                editCustomer.Text = "Save";
            }
            else
            {
                MyCustomer myCustomer = new MyCustomer();
                bool ok = true;
                errP.Clear();

                try
                {
                    myCustomer.IDNo = Convert.ToInt32(lblEditCustomer.Text.Trim()); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblEditCustomer, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = txtEditSurname.Text.Trim(); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSurname, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = txtEditSurname.Text.Trim(); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditSurname, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = txtEditStreet.Text.Trim(); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditStreet, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = txtEditTown.Text.Trim(); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTown, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = txtEditCounty.Text.Trim(); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditCounty, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = txtEditPostcode.Text.Trim(); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditPostcode, MyEx.toString());
                }

                try
                {
                    myCustomer.Title = txtEditTelNo.Text.Trim(); //passed to Customer class to check
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtEditTelNo, MyEx.toString());
                }

                try
                {
                    if (ok)
                    {
                        drCustomer.BeginEdit();

                        drCustomer["CustomerNo"] = myCustomer.IDNo;
                        drCustomer["Title"] = myCustomer.Title;
                        drCustomer["Forename"] = myCustomer.Forename;
                        drCustomer["Surname"] = myCustomer.Surname;
                        drCustomer["Street"] = myCustomer.Street;
                        drCustomer["Town"] = myCustomer.Town;
                        drCustomer["County"] = myCustomer.County;
                        drCustomer["Postcode"] = myCustomer.Postcode;
                        drCustomer["TelNo"] = myCustomer.TelNo;

                        drCustomer.EndEdit();
                        daCustomer.Update(dsInTheDogHouse, "Customer");

                        MessageBox.Show("Details Updated", "Customer");

                        cmbEditTitle.Enabled = false;
                        txtEditSurname.Enabled = false;
                        txtEditSurname.Enabled = false;
                        txtEditStreet.Enabled = false;
                        txtEditTown.Enabled = false;
                        txtEditCounty.Enabled = false;
                        txtEditPostcode.Enabled = false;
                        txtEditTelNo.Enabled = false;

                        lblEditCustomer.Text = "Edit";
                        tabCustomer.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "" + ex.Message, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void tabCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabCustomer.SelectedIndex;

            tabCustomer.TabPages[tabCustomer.SelectedIndex].Focus();
            tabCustomer.TabPages[tabCustomer.SelectedIndex].CausesValidation = true;

            //if(dgvCustomer.SelectedRows.Count == 0 && tabCustomers.SelectedIndex == 2)
            //tabCustomer.TabPages[tabCustomer.SelectedIndex].CausesValaidation = true;
            //else
            //{

            switch (tabCustomer.SelectedIndex)
            {
                case 0: //display tab selected
                    {
                        dsInTheDogHouse.Tables["Customer"].Clear();
                        daCustomer.Fill(dsInTheDogHouse, "Customer");

                        break;
                    }
                case 1: //Add tab selected
                    {
                        int noRows = dsInTheDogHouse.Tables["Customer"].Rows.Count;

                        if (noRows == 0)
                        {
                            lblAddCustNo.Text = "1000";
                        }
                        else
                        {
                            getNumber(noRows);
                        }

                        errP.Clear();
                        voidClearAddForm();
                        break;
                    }
                case 2: //Edit Tab Selected
                    {
                        if (custNoSelected == 0)
                        {
                            tabCustomer.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lblEditCustomer.Text = custNoSelected.ToString();

                            drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(lblEditCustomer.Text);

                            if (drCustomer["Title"].ToString() == "Mr")
                                cmbEditTitle.SelectedIndex = 0;
                            if (drCustomer["Title"].ToString() == "Mr")
                                cmbEditTitle.SelectedIndex = 1;
                            if (drCustomer["Title"].ToString() == "Mr")
                                cmbEditTitle.SelectedIndex = 2;
                            if (drCustomer["Title"].ToString() == "Mr")
                                cmbEditTitle.SelectedIndex = 3;

                            txtEditSurname.Text = drCustomer["Forename"].ToString();
                            txtEditSurname.Text = drCustomer["Surname"].ToString();
                            txtEditStreet.Text = drCustomer["Street"].ToString();
                            txtEditTown.Text = drCustomer["Town"].ToString();
                            txtEditCounty.Text = drCustomer["County"].ToString();
                            txtEditPostcode.Text = drCustomer["Postcode"].ToString();
                            txtEditTelNo.Text = drCustomer["Telephone Number"].ToString();

                            break;
                        }
                    }
            }
        }

        void AddTabValidate(object sender, CancelEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        }

        void EditTabValidate(object ssender, CancelEventArgs e)
        {
            if (custSelected == false && custNoSelected == 0)
            //have to do this bit here
            //reset tab to display and put out message to select a customer
            {
                custSelected = false;
                custNoSelected = 0;
            }
            else if (dgvCustomers.SelectedRows.Count == 1)
            {
                custSelected = true;
                custNoSelected = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            }
        }

        private void btnDisplayDelete_Click(object sender, EventArgs e)
        {

            //if (istCustomers.SelectedIndices.Count == 0)
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer from the list.", "Select Customer");
            }
            else
            {
                drCustomer = dsInTheDogHouse.Tables["Customer"].Rows.Find(dgvCustomers.SelectedRows[0].Cells[0].Value);

                string tempName = drCustomer["Forename"].ToString() + "" + drCustomer["Surname"].ToString() + "\'s";

                if (MessageBox.Show("Are you sure you want to delete: " + tempName + "Details?", "Add Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drCustomer.Delete();
                    daCustomer.Update(dsInTheDogHouse, "Customer");
                }
            }
        }

        private void frmDogHouse_Shown(object sender, EventArgs e)
        {
            tabCustomer.TabPages[0].CausesValidation = true;
            tabCustomer.TabPages[0].Validating += new CancelEventHandler(AddTabValidate);

            tabCustomer.TabPages[2].CausesValidation = true;
            tabCustomer.TabPages[2].Validating += new CancelEventHandler(EditTabValidate);


        }

        

        private void frmDogHouse_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source =.; Initial Catalog = InTheDogHouse; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            dgvCustomers.DataSource = dsInTheDogHouse.Tables["Customer"];

            //Resize the dataGridView columns to fit the newly loaded content. 
            dgvCustomers.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells);

            tabCustomer.SelectedIndex = 1;
            tabCustomer.SelectedIndex = 0;
        }



    }
}
