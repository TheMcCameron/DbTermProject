using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTermProject.Domain.Models
{
    public class Buyer : DomainObject
    {
        public Buyer()
        {
            this.Bids = new HashSet<Bid>();
        }
        public string BuyerName { get; set; }
        public ICollection<Bid> Bids { get; set; }
    }
}
