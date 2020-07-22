using CrmBL.DataBase;
using System.Windows.Forms;

namespace CrmUI.Forms
{
    public partial class LoginForm : Form
    {
        public Customer Customer { get; private set; }

        public LoginForm() => InitializeComponent();

        private void ButtonEnter_Click(object sender, System.EventArgs e)
        {
            Customer = new Customer() { Name = UserName.Text };
        }

        private void UserName_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text))
                ButtonEnter.Enabled = false;           
            else ButtonEnter.Enabled = true;
        }
    }
}
