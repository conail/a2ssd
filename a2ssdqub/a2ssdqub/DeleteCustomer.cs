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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();

        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {
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

            // comAllCus.SelectedValue would give just the cusID
            MessageBox.Show("YOU HAVE JUST DELETED " + comAllCus.Text);

            refreshCombo();
        }

        private void refreshCombo()
        {
            comAllCus.DataSource = CustomerDAL.Get(); 
            comAllCus.ValueMember = "CusID";
            comAllCus.DisplayMember = "";
        }
    }
}
