using OrderDomain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDomain.AggregateModels.BuyerModels
{
    public class Buyer:BaseEntity
    {

        public string UserName { get; private set; }

    

        public Buyer(string userName)
        {
            UserName = userName;
         
        }
    }
}
