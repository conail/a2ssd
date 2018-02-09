using System;
using System.Windows.Forms;
using a2ssdqub.DAL;

namespace a2ssdqub.UI
{
    public partial class DeleteReceipt: Form
    {
        public DeleteReceipt()
        {
            InitializeComponent();
            refreshCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }

        private void btnDelCus_Click(object sender, EventArgs e)
        {
            CustomerDAL.Delete((int) comAllCus.SelectedValue);
            MessageBox.Show("YOU HAVE JUST DELETED " + comAllCus.Text);
            refreshCombo();
        }

        private void refreshCombo()
        {
            comAllCus.DataSource = ReceiptDAL.Get(); 
            comAllCus.ValueMember = "Id";
            comAllCus.DisplayMember = "";
        }
    }
}
