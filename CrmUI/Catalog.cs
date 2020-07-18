using System.Data.Entity;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        public Catalog(DbSet<T> dbSet)
        {
            InitializeComponent();
            dataGridView.DataSource = dbSet.Local.ToBindingList();
        }
    }
}