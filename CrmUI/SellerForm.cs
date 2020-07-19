using CrmBL.Model;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click
            (object sender, System.EventArgs e)
        {
            Seller = new Seller()
            {
                Name = textBox1.Text
            };

            Close();
        }

        private void ButtonCancel_Click
            (object sender, System.EventArgs e)
        {
            Close();
        }
    }
}