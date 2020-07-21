using CrmBL.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        private readonly CrmContext dbContext;
        private readonly DbSet<T> dbSet;

        public Catalog(CrmContext dbContext)
        {
            InitializeComponent();
            var dbSet = dbContext.Set<T>();

            this.dbContext = dbContext;            
            this.dbSet = dbSet;
            
            dbSet.Load();
            dataGridView.DataSource = dbSet.Local.ToBindingList();
        }

        private void ButtonAdd_Click
            (object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Product))
            {
                var form = new ProductForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    dbContext.Products.Add(form.Product);
                    dbContext.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                var form = new SellerForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    dbContext.Sellers.Add(form.Seller);
                    dbContext.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                var form = new CustomerForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    dbContext.Customers.Add(form.Customer);
                    dbContext.SaveChanges();
                }
            }
        }

        private void ButtonEdit_Click
            (object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                if (dbSet.Find(id) is Product product)
                {
                    var form = new ProductForm(product);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dbContext.SaveChanges();
                        dataGridView.Refresh();
                    }
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                if (dbSet.Find(id) is Seller seller)
                {
                    var form = new SellerForm(seller);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dbContext.SaveChanges();
                        dataGridView.Refresh();
                    }
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                if (dbSet.Find(id) is Customer customer)
                {
                    var form = new CustomerForm(customer);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dbContext.SaveChanges();
                        dataGridView.Refresh();
                    }
                }
            }
        }

        private void ButtonDelete_Click
            (object sender, EventArgs e) { }
    }
}