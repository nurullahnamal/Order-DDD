using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDomain.Events
{
    public class OrderStartedDomainEvent:INotification
    {
       

        public string UserName { get; set; }
     

        public OrderDomain.AggregateModels.OrderModels.Order Order{ get; set; }

        public OrderStartedDomainEvent(string userName, OrderDomain.AggregateModels.OrderModels.Order order)
        {
            UserName = userName;
            Order = order;
        }
    }
}
