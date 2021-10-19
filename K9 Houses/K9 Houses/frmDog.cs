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
    public partial class frmDog : Form
    {
        SqlDataAdapter daDog, daCustomer, daBreed;
        DataSet dsInTheDogHouse = new DataSet();
        SqlCommandBuilder cmdBDog, cmdBCustomer, cmdBBreed;
        DataRow drDog;
        String connStr, sqlDog, sqlCustomer, sqlBreed;

        

        int selectedTab = 0;
        bool dogSelected = false;

        

        int dogNoSelected;


        private void frmDog_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = .; Initial Catalog = InTheDoghouse; Integrated Security = true";

            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Customer");
            daCustomer.Fill(dsInTheDogHouse, "Customer");

            sqlBreed = @"select * from Dog";
            daDog = new SqlDataAdapter(sqlDog, connStr);
            cmdBDog = new SqlCommandBuilder(daDog);
            daCustomer.FillSchema(dsInTheDogHouse, SchemaType.Source, "Dog");
            daCustomer.Fill(dsInTheDogHouse, "Dog");

            dgvDogs.DataSource = dsInTheDogHouse.Tables["Dog"];

            dtpAddDOB.MinDate = new DateTime(2000, 1, 1);

            dgvDogs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            cmbAddBreedNo.DataSource = dsInTheDogHouse.Tables["Breed"];
            cmbAddBreedNo.ValueMember = "CustomerNo";
            cmbAddBreedNo.DisplayMember = "BreedName";

            cmbAddCustNo.DataSource = dsInTheDogHouse.Tables["Customer"];
            cmbAddCustNo.ValueMember = "CustomerNo";
            cmbAddCustNo.DisplayMember = "CustomerNo";

            tabDog.SelectedIndex = 1;
            tabDog.SelectedIndex = 0;

        }

        public frmDog()
        {
            InitializeComponent();
        }

        private void dogAddAdd_Click(object sender, EventArgs e)
        {
            tabDog.SelectedIndex = 1;
        }

        void clearAddForm()
        {
            txtDogName.Clear();
            cmbAddBreedNo.SelectedIndex = -1;
            dtpAddDOB.Value = DateTime.Today;
            cmbAddGender.SelectedIndex = -1;
            dogColour.Clear();
            cmbAddCustNo.SelectedIndex = -1;
        }

        private void getNumber(int noRows)
        {
            drDog = dsInTheDogHouse.Tables["Dog"].Rows[noRows - 1];
            lblAddDogNo.Text = (int.Parse(drDog["DogNo"].ToString()) + 1).ToString();
        }

        private void tabDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTab = tabDog.SelectedIndex;

            tabDog.TabPages[tabDog.SelectedIndex].Focus();
            tabDog.TabPages[tabDog.SelectedIndex].CausesValidation = true;

            switch (tabDog.SelectedIndex)
            {
                case 0: //Display tab Selected
                    {
                        dsInTheDogHouse.Tables["Dog"].Clear();
                        daDog.Fill(dsInTheDogHouse, "Dog");

                        break;
                    }

                case 1: // add tab selection
                    {
                        int noRows = dsInTheDogHouse.Tables["Dog"].Rows.Count;

                        if (noRows == 0)
                            lblAddDogNo.Text = "5000";
                        else
                        {
                            getNumber(noRows);
                        }

                        errP.Clear();
                        clearAddForm();
                        break;
                    }

                case 2:
                    {
                        if (dogNoSelected == 0)
                        {
                            tabDog.SelectedIndex = 0;
                            break;
                        }
                        else
                        {
                            lblAddDogNo.Text = dogNoSelected.ToString();

                            drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(lblAddDogNo.Text);

                            if (drDog["Gender"].ToString() == "M")
                                editGenderCmb.SelectedIndex = 0;
                            if (drDog["Gender"].ToString() == "F")
                                editGenderCmb.SelectedIndex = 1;

                            editDogName.Text = drDog["Name"].ToString();
                            editColour.Text = drDog["Colour"].ToString();

                            editBreedNo.SelectedIndex = editBreedNo.FindStringExact(drDog["BreedNo"].ToString());
                            editBreedNo.Text = drDog["BreedNo"].ToString();
                            dtpAddDOB.Value = Convert.ToDateTime(drDog["DOB"].ToString());
                            editCustNo.SelectedIndex = editCustNo.FindStringExact(drDog["CustomerNo"].ToString());

                            break;
                        }
                    }
            }
        }

    

        private void dogDisplayDelete_Click(object sender, EventArgs e)
        {
            tabDog.SelectedIndex = 2;
        }

        private void exitDogBtn_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the addition of Dog No: " + lblAddDogNo.Text + "?", "Add Dog", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                tabDog.SelectedIndex = 0;
        }

        private void dogDisplayEdit_Click(object sender, EventArgs e)
        {
            //if(lstCustomers.selectedindices.Count == 0)
            if (dgvDogs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Dog from the list", "Select Dog");

            }
            else
            {
                drDog = dsInTheDogHouse.Tables["Dog"].Rows.Find(dgvDogs.SelectedRows[0].Cells[0].Value);

                string tempName = drDog["Name"].ToString() + "#'S";

                if (MessageBox.Show("Are you sure you want to delete" + tempName + " details", "Add Dog", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    drDog.Delete();
                    daDog.Update(dsInTheDogHouse, "Dog");
                }
            }
        }


        void AddTableValidate(object sender, EventArgs e)
        {
            if (dgvDogs.SelectedRows.Count == 0)
            {
                dogSelected = false;
                dogNoSelected = Convert.ToInt32(dgvDogs.SelectedRows[0].Cells[0].Value);
            }
        }

        void EditTabValidate(object sender, EventArgs e)
        {
            if (dogSelected == false && dogNoSelected == 0)
            {
                dogSelected = false;
                dogNoSelected = 0;

            }
            else if (dgvDogs.SelectedRows.Count == 1)
            {
                dogSelected = true;
                dogNoSelected = Convert.ToInt32(dgvDogs.SelectedRows[0].Cells[0].Value);
            }
        }

        private void frmDog_Shown(object sender, EventArgs e)
        {
            tabDog.TabPages[0].CausesValidation = true;
            tabDog.TabPages[0].Validating += new CancelEventHandler(AddTableValidate);

            tabDog.TabPages[2].CausesValidation = true;
            tabDog.TabPages[2].Validating += new CancelEventHandler(AddTableValidate);
        }

        private void btnAddAdd_Click(object sender, EventArgs e)
        {
            MyDog myDog = new MyDog();
            bool ok = true;
            errP.Clear();

            try
            {
                myDog.DogNo = Convert.ToInt32(lblAddDogNo.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblAddDogNo, MyEx.toString());
            }

            try
            {
                // myDog.name = txtAddName.Text.Trim();
            }
            catch (MyException myex)
            {
                ok = false;
                errP.SetError(txtDogName, myex.toString());
            }
        }


    }
}

