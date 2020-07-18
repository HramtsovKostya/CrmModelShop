using CrmBL.Model;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, System.EventArgs e)
        {
            Customer = new Customer()
            {
                Name = textBox1.Text
            };

            Close();
        }

        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}