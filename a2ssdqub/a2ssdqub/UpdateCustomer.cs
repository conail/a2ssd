using a2ssdqub.DAL; 
using System;
using System.Linq;
using System.Windows.Forms;
using a2ssdqub.Models;

namespace a2ssdqub
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            lisCus.ValueMember = "CusID"; // we'll be using this from the Model
            lisCus.DisplayMember = ""; // thank you Stack OVerflow

            // Kick start the form
            RefreshForm();

            // Populate the list first (as above)
            // ...then attach/assign the event handler
            lisCus.SelectedValueChanged += lisCus_SelectedValueChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Program.mainM.Show();
        }

        private void lisCus_SelectedValueChanged(object sender, EventArgs e)
        {
            lisCus.Enabled = false;
            btnUpdate.Enabled = true;
            lblCusID.Text = lisCus.SelectedValue.ToString();

            var customer = CustomerDAL.Get((int) lisCus.SelectedValue);
            txtForename.Text = customer.Forename;
            dtpDob.Value = customer.Dob;
            panForm.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text == customer.Sex).Checked = true;
            
            panForm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customer = (Customer) lisCus.SelectedItem;
            customer.Forename = txtForename.Text;
            customer.Dob = dtpDob.Value;
            customer.Sex = panForm.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            MessageBox.Show(CustomerDAL.Update(customer) ? "Yeah that updated :-)" : "Baaaad news");

            RefreshForm();
        }

        private void RefreshForm()
        {
            lisCus.DataSource = CustomerDAL.Get();
            btnUpdate.Enabled = false;
            lisCus.Enabled = true;

            // Wipe the form
            lblCusID.Text = txtForename.Text = dtpDob.Text = "";
            panForm.Controls.OfType<RadioButton>().Select(x => x.Checked = false);

            // Hide the right-hand panel?
            panForm.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}