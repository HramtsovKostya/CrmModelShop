using CrmBL.DataBase;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CrmBL.Model
{
    public class Cart : IEnumerable<Product>
    {
        public Customer Customer { get; set; }
        public Dictionary<Product, int> Products { get; private set; }
        public decimal FullPrice => GetAllProducts().Sum(p => p.Price);

        public Cart(Customer customer)
        {
            Customer = customer;
            Products = new Dictionary<Product, int>();
        }

        public void Add(Product product)
        {
            if (Products.TryGetValue(product, out int count))
                Products[product] = ++count;            
            else Products.Add(product, 1);            
        }

        public void Remove(Product product)
        {
            if (Products.TryGetValue(product, out int count))
            {
                if (count > 1) Products[product] = --count;
                else Products.Remove(product);
            }    
        }

        public List<Product> GetAllProducts()
        {
            var result = new List<Product>();
            foreach (var item in this) result.Add(item);
            return result;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            foreach (var product in Products.Keys)
                for (int i = 0; i < Products[product]; i++)
                    yield return product;               
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}