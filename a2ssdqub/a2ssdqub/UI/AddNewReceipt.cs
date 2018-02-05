using System;
using System.Windows.Forms;
using a2ssdqub.DAL;
using a2ssdqub.Models;

namespace a2ssdqub.UI
{
    public partial class frmAddNewReceipt : Form
    {
        public frmAddNewReceipt()
        {
            InitializeComponent();

            comCustomer.DataSource = CustomerDAL.Get();
            comCustomer.ValueMember = "CusID";
            comCustomer.DisplayMember = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpDateIssue.Text == "" || comCustomer.Text == "" || comPay.Text == "" || txtTotalDue.Text != "")
            {
                MessageBox.Show("Please complete all fields");
                return;
            }

            var r = new Receipt(dtpDateIssue.Value, float.Parse(txtTotalDue.Text), comPay.Text, false, null);
            int? id = ReceiptsDAL.Add(r);

            if (id > 0)
            {
                var str = string.Format("Receipt ID {0} has been successfully added with a total of £{1}", id, txtTotalDue.Text);
                MessageBox.Show(str);
                tssMessage.Text = str;
                dtpDateIssue.Text = comCustomer.Text = comPay.Text = txtTotalDue.Text = "";
            }
            else MessageBox.Show("ERROR: RECEIPT NOT SAVED.  Please check it carefully and try again.");
        }

        private void btnCloseFrm_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }
    }
}