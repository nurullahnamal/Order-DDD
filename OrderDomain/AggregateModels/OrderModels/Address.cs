using OrderDomain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDomain.AggregateModels.OrderModels
{
    public class Address : ValueObject
    {

        public string City { get; set; }
        public string Country { get; set; }


        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return City;
            yield return Country;
        }
    }
}
