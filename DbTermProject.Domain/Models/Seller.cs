using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTermProject.Domain.Models
{
    public class Seller : DomainObject
    {
        public Seller()
        {
            this.Items = new HashSet<Item>();
        }
        public string SellerName { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
