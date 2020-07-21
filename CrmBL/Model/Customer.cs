using System.Collections.Generic;

namespace CrmBL.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Check> Ckecks { get; set; }
        public override string ToString() => Name;
    }
}