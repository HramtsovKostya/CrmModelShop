using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm() => InitializeComponent();

        public SellerForm(Seller seller) : this()
        {
            Seller = seller;
            textBox1.Text = Seller.Name;
        }

        private void ButtonOK_Click
            (object sender, EventArgs e)
        {
            var seller = Seller ?? new Seller();

            seller.Name = textBox1.Text;
            Seller = seller; Close();
        }

        private void ButtonCancel_Click
            (object sender, EventArgs e) => Close();
    }
}