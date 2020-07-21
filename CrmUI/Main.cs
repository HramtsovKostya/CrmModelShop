using System;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI
{
    public partial class Main : Form
    {
        private readonly CrmContext dbContext;

        public Main()
        {
            InitializeComponent();
            dbContext = new CrmContext();
        }

        private void ProductToolStripMenuItem_Click
            (object sender, EventArgs e) => FormShow<Product>();

        private void SellerToolStripMenuItem_Click
            (object sender, EventArgs e) => FormShow<Seller>();

        private void CustomerToolStripMenuItem_Click
            (object sender, EventArgs e) => FormShow<Customer>();

        private void CheckToolStripMenuItem_Click
            (object sender, EventArgs e) => FormShow<Check>();

        private void FormShow<T>() where T : class 
            => new Catalog<T>(dbContext).Show();

        private void CustomerAddToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            var form = new CustomerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dbContext.Customers.Add(form.Customer);
                dbContext.SaveChanges();
            }            
        }

        private void SellerAddToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            var form = new SellerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dbContext.Sellers.Add(form.Seller);
                dbContext.SaveChanges();
            }
        }

        private void ProductAddToolStripMenuItem_Click
            (object sender, EventArgs e)
        {
            var form = new ProductForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dbContext.Products.Add(form.Product);
                dbContext.SaveChanges();
            }
        }

        private void ModelingToolStripMenuItem_Click
            (object sender, EventArgs e) => new ModelForm().Show();
    }
}