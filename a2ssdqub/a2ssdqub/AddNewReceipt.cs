using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using a2ssdqub.DAL;
using a2ssdqub.Models; // ! //

namespace a2ssdqub
{
    public partial class frmAddNewReceipt : Form
    {
        public frmAddNewReceipt()
        {
            InitializeComponent();
            RefreshCusFKCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dtpDateIssue.Text != "" && comCustomer.Text != "" && comPay.Text != "" && txtTotalDue.Text != "")
            {
                int newlyMadeID = ReceiptsDAL.AddNewReceipt(dtpDateIssue.Text, int.Parse(comCustomer.Text.Split(',')[0]), decimal.Parse(txtTotalDue.Text), comPay.Text);

                if (newlyMadeID > -1)
                {
                    string newsflash = "Receipt ID " + newlyMadeID + " has been successfully added with a total of £" + txtTotalDue.Text;
                    MessageBox.Show(newsflash);
                    tssMessage.Text = newsflash;
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("ERROR: RECEIPT NOT SAVED.  Please check it carefully and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
        }


        // Use the CustomerDAL
        private void RefreshCusFKCombo()
        {
            // List<Customer> comboVals = CustomerDAL.GetListOfCustomers();
            // null - binds 1 property of the comboVals to the comboBox, but we won't
            // to ensure both the key and value are available
            // instead of replacing it with "Key" or "Value"
            // as a Dictionary always has 1 of each
            comCustomer.DataSource = CustomerDAL.Get();
            // These controls work on any other form field that only shows 1 value at a time
            // comCustomer.DisplayMember = "Value";
            comCustomer.ValueMember = "CusID";
        }


        private void btnCloseFrm_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }


        private void ClearForm()
        {
            dtpDateIssue.Text = "";
            comCustomer.Text = "";
            comPay.Text = "";
            txtTotalDue.Text = "";
        }
    }
}
