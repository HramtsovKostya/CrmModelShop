using CrmBL.DataBase;
using System;
using System.Windows.Forms;

namespace CrmUI.Forms
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
            Seller = Seller ?? new Seller();
            Seller.Name = textBox1.Text;
            Close();
        }

        private void ButtonCancel_Click
            (object sender, EventArgs e) => Close();
    }
}