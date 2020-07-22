using CrmBL.DataBase;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CrmUI.Forms
{
    public partial class Catalog<T> : Form where T : class
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
            DataGrid_CheckData();

            if (typeof(T) == typeof(Check))
            {
                ButtonAdd.Enabled = false;
                ButtonEdit.Enabled = false;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
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

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Product))
            {
                if (dbSet.Find(GetId()) is Product product)
                    DataBase_EditData(new ProductForm(product));
            }
            else if (typeof(T) == typeof(Seller))
            {
                if (dbSet.Find(GetId()) is Seller seller)
                    DataBase_EditData(new SellerForm(seller));              
            }
            else if (typeof(T) == typeof(Customer))
            {
                if (dbSet.Find(GetId()) is Customer customer)
                    DataBase_EditData(new CustomerForm(customer)); 
            }
        }

        private void DataBase_EditData(Form form)
        {
            if (form.ShowDialog() == DialogResult.OK) 
                DataBase_SaveChanges();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Product))
            {
                if (dbSet.Find(GetId()) is Product product)
                {
                    dbContext.Products.Remove(product);
                    DataBase_SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                if (dbSet.Find(GetId()) is Seller seller)
                {
                    dbContext.Sellers.Remove(seller);
                    DataBase_SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                if (dbSet.Find(GetId()) is Customer customer)
                {
                    dbContext.Customers.Remove(customer);
                    DataBase_SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Check))
            {
                if (dbSet.Find(GetId()) is Check check)
                {
                    dbContext.Checks.Remove(check);
                    DataBase_SaveChanges();
                }
            }
            DataGrid_CheckData();
        }

        private void DataBase_SaveChanges()
        {
            dbContext.SaveChanges();
            dataGridView.Refresh();
        }

        private void DataGrid_CheckData()
        {
            if (dataGridView.Rows.Count > 0) ButtonDelete.Enabled = true;
            else ButtonDelete.Enabled = false;
        }

        private object GetId()
        {
            return dataGridView.SelectedRows[0].Cells[0].Value;
        }
    }
}