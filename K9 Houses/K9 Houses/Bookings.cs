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
    public partial class Bookings : Form
    {

        Button[] btns = new Button[26];

        SqlDataAdapter daNames, daCustomers, daBooking, daBooking2, daBookingDet, daBookingDet2, daDogs, daKennels;
        DataSet dsInTheDogHouse = new DataSet();
        SqlConnection conn;
        SqlCommand cmdBooking, cmdBookingDet, cmdCustomerDetails, cmdKennelDetails, cmdDogDetails;
        SqlCommandBuilder cmdBBooking2, cmdBBookingDet2;
        DataRow drCustomer;

        String sqlNames, sqlCustomerDetails, sqlBooking, sqlBooking2, sqlBookingDet, sqlBookingDet2;
        String sqlDogDetails, sqlKennelDetails, connStr;

        public Bookings()
        {
            InitializeComponent();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            int no;

            //lblBooking Date. Text = DateTime.Now.ToShortDateString();
            //dtpStartDate.MiniDate = DateTime.Now;

            for (int i = 0; i < 26; i++)
            {
                btns[i]=(Button)pnlButtons.Controls[i];
                btns[i].Text = "" + (char)(65 + i);
                btns[i].Enabled = false;
                btns[i].Click += new EventHandler(button2_Click);

            }

            connStr = @" Data Source = .;"
        }
       
    }
}
