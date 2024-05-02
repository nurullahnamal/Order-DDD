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

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Buyer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
