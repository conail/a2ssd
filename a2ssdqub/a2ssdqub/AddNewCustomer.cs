using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // used for radio button, a fluent API
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a2ssdqub.DAL; // >> ADD THIS IN TO 028Educate
using a2ssdqub.Models; // CustomerDAL.AddNew will now work

namespace a2ssdqub
{
    public partial class AddNewCustomer : Form
    {
        private const string ID_ALERT = "A new Customer ID will be created automatically";

        public AddNewCustomer()
        {
            InitializeComponent();
            lblIdMsg.Text = ID_ALERT;
            tssText.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Quickest, most efficient way to do it; uses Linq
            // FirstOrDef takes IEnumerable and returns an instance of IEnumerable???
            // Tries to keep the IEnumerable alive as long as possible to chain it to other functions
            // Iterates through and checks which are of type RadioButton
            // Checks where the Checked property is true
            // FirstOrDefault - pins it to one value, a reducing function
            // Microsoft are v proud of Linq and have written it for almost any data set out there
            // They started a project Linq To SQL, so you could just know Linq not SQL
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (txtForename.Text != "" && datDob.Text != "" && checkedButton.Text != "")
            {
                int newlyMadeID = CustomerDAL.Add(new Customer(txtForename.Text, datDob.Value, checkedButton.Text));

                if(newlyMadeID > -1)
                {
                    string newsflash = txtForename.Text + " has been successfully added, with Customer ID " + newlyMadeID;
                    MessageBox.Show(newsflash);
                    // lblIdMsg.Text = "Customer ID " + newlyMadeID;
                    tssText.Text = newsflash;
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("ERROR: NO NEW CUSTOMER ADDED.  Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }

        private void ClearForm()
        {
            lblIdMsg.Text = ID_ALERT;
            txtForename.Text = "";
            datDob.Text = "";

            radMale.Checked = false;
            radFemale.Checked = false;
            radUndisclosed.Checked = false;
            radUnknown.Checked = false;

            // tssText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
