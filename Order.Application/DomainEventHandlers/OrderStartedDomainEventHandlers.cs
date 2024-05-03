using MediatR;
using Order.Application.Repository;
using OrderDomain.AggregateModels.BuyerModels;
using Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OrderDomain.Events;

namespace Order.Application.DomainEventHandlers
{
    public class OrderStartedDomainEventHandlers : INotificationHandler<OrderStartedDomainEvent>
    {
        private readonly IBuyerRepository buyerRepository;

        public OrderStartedDomainEventHandlers(IBuyerRepository buyerRepository)
        {
            this.buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
        }

        public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
        {
            if (notification.Order.UserName == "")
            {
                var buyer =new Buyer(notification.UserName);
                //buyerRepository.add(buyer);  

               
            }
            return Task.CompletedTask;
        }
    }
}
