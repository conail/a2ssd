using System;
using System.Windows.Forms;

namespace a2ssdqub.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openSubForm(object sender, EventArgs e)
        {
            Hide();
            switch(((Control) sender).Name)
            {
                case "btnAddCus": (new AddNewCustomer()).Show(); break;
                case "btnDelCus": (new DeleteCustomer()).Show(); break;
                case "btnAddReceipt": (new frmAddNewReceipt()).Show(); break;
                case "button1": (new UpdateCustomer()).Show(); break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}