using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTermProject.Domain.Models
{
    public class Bid : DomainObject
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Item Item { get; set; }
        public Buyer Buyer { get; set; }
    }
}
