﻿using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI
{
    public partial class Main : Form
    {
        private readonly CrmContext dataBase;

        public Main()
        {
            InitializeComponent();
            dataBase = new CrmContext();
        }

        private void ProductToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(dataBase.Products);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(dataBase.Sellers);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(dataBase.Customers);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(dataBase.Checks);
            catalogCheck.Show();
        }

        private void CustomerAddToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            var form = new CustomerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dataBase.Customers.Add(form.Customer);
                dataBase.SaveChanges();
            }            
        }

        private void SellerAddToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            var form = new SellerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dataBase.Sellers.Add(form.Seller);
                dataBase.SaveChanges();
            }
        }

        private void ProductAddToolStripMenuItem_Click
            (object sender, System.EventArgs e)
        {
            var form = new ProductForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dataBase.Products.Add(form.Product);
                dataBase.SaveChanges();
            }
        }
    }
}