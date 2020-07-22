using CrmBL.DataBase;
using CrmBL.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI.Forms
{
    public partial class MainForm : Form
    {
        private readonly Random rnd;
        private readonly CrmContext dbContext;
        private CashDesk cashDesk;
        private Cart cusrtomerCart;
        private Customer customer;

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random(DateTime.Now.Millisecond);
            dbContext = new CrmContext();            
            cusrtomerCart = new Cart(customer);  
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow<Product>("Список товаров");
        }

        private void SellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow<Seller>("Список продавцов");
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow<Customer>("Список покупателей");
        }

        private void ChecksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow<Check>("Список чеков");
        }

        private void FormShow<T>(string caption) where T : class
        {
            var form = new Catalog<T>(dbContext) { Text = caption };
            form.Show();
        }

        private void ModelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModelForm().Show();
        }

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
                cusrtomerCart.Add(product);
                CartList.Items.Add(product);
                UpdateLists();
                ButtonPay_Activate();
            }
        }

        private void ButtonPay_Activate()
        {
            if (CartList.Items.Count != 0) ButtonPay.Enabled = true;           
            else ButtonPay.Enabled = false;           
        }

        private void CartList_DoubleClick(object sender, EventArgs e)
        {
            if (CartList.SelectedItem is Product product)
            {
                cusrtomerCart.Remove(product);
                CartList.Items.Remove(product);
                UpdateLists();
                ButtonPay_Activate();
            }
        }

        private void UpdateLists()
        {
            CartList.Items.Clear();
            CartList.Items.AddRange(cusrtomerCart.GetAllProducts().ToArray());
            SetFullPrice();
        }

        private void SetFullPrice()
        {
            FullPriceLabel.Text = $"Итого: {cusrtomerCart.FullPrice} руб.";
        }

        private void EnterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

                cusrtomerCart.Customer = customer;
                EnterLabel.Text = $"Здравствуйте, {customer}";
            } 
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                cashDesk = new CashDesk(1, SetRandomSeller(), dbContext) { IsModel = false };

                cashDesk.Enqueue(cusrtomerCart);
                var price = cashDesk.Dequeue();
                CartList.Items.Clear();
                cusrtomerCart = new Cart(customer);
                SetFullPrice();
                ButtonPay.Enabled = false;

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

        private Seller SetRandomSeller()
        {
            var randomSellerId = rnd.Next(1, dbContext.Sellers.Count() + 1);
            var seller = dbContext.Sellers.FirstOrDefault(s => s.SellerId == randomSellerId);

            return seller;
        }
    }
}