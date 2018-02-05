using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using a2ssdqub.DAL; 
using a2ssdqub.Models;

namespace a2ssdqub
{
    public partial class AddNewCustomer : Form
    {
        private const string ID_ALERT = "A new Customer ID will be created automatically";

        public AddNewCustomer()
        {
            InitializeComponent();
            ClearForm();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (txtForename.Text == "" || datDob.Text == "" || checkedButton.Text == "")
            {
                MessageBox.Show("Please complete all fields");
                return;
            }
            
            int id = CustomerDAL.Add(new Customer(txtForename.Text, datDob.Value, checkedButton.Text));
            if(id > 0)
            {
                var str = string.Format("{0} has been successfully added, with Customer ID {1}.", txtForename.Text, id);
                MessageBox.Show(str);
                tssText.Text = str;
                ClearForm();
                MessageBox.Show("ERROR: NO NEW CUSTOMER ADDED.  Please try again.");
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
            txtForename.Text = datDob.Text = "";
            this.Controls.OfType<RadioButton>().Select(x => x.Checked = false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}