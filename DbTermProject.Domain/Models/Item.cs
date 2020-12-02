using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTermProject.Domain.Models
{
    public class Item : DomainObject
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public float InitialPrice { get; set; }
        public float SoldPrice { get; set; }
        public Seller Seller { get; set; }
    }
}
