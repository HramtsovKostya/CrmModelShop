using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.DataBase;
using CrmBL.Model;

namespace CrmUI.Forms
{
    public partial class Main : Form
    {
        private readonly CrmContext dbContext;
        private readonly CashDesk cashDesk;
        private Cart cart;
        private Customer customer;

        public Main()
        {
            InitializeComponent();
            dbContext = new CrmContext();            
            cart = new Cart(customer);

            var seller = dbContext.Sellers.FirstOrDefault();
            cashDesk = new CashDesk(1, seller, dbContext) { IsModel = false };
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

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                ProductsList.Items.AddRange(dbContext.Products.ToArray());
                ProductsList.Invoke((Action)delegate { UpdateLists(); });                
            });
        }

        private void Products_DoubleClick(object sender, EventArgs e)
        {
            if (ProductsList.SelectedItem is Product product)
            {
                cart.Add(product);
                CartList.Items.Add(product);
                UpdateLists();
                ButtonPay_Activate();
            }
        }

        private void ButtonPay_Activate()
        {
            if (CartList.Items.Count != 0)
                ButtonPay.Enabled = true;           
            else ButtonPay.Enabled = false;           
        }

        private void CartList_DoubleClick(object sender, EventArgs e)
        {
            if (CartList.SelectedItem is Product product)
            {
                cart.Remove(product);
                CartList.Items.Remove(product);
                UpdateLists();
                ButtonPay_Activate();
            }
        }

        private void UpdateLists()
        {
            CartList.Items.Clear();
            CartList.Items.AddRange(cart.GetAllProducts().ToArray());
            FullPriceLabel.Text = $"Итого: {cart.FullPrice} руб.";
        }

        private void EnterLabel_LinkClicked
            (object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new LoginForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var tempCustomer = dbContext.Customers
                    .FirstOrDefault(c => c.Name.Equals(form.Customer.Name));

                if (tempCustomer != null)
                {
                    customer = tempCustomer;                    
                }
                else
                {
                    dbContext.Customers.Add(form.Customer);
                    dbContext.SaveChanges();
                    customer = form.Customer;
                }

                cart.Customer = customer;
                EnterLabel.Text = $"Здравствуй, {customer}";
            } 
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                cashDesk.Enqueue(cart);
                var price = cashDesk.Dequeue();
                CartList.Items.Clear();
                cart = new Cart(customer);

                MessageBox.Show("Покупка выполнена успешно." +
                    $" Сумма: {price} руб.", "Покупка выполнена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Авторизуйтесь, пожалуйста!", "Ошибка авторизации",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}