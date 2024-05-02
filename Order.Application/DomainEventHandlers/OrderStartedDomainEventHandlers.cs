using MediatR;
using Order.Application.Repository;
using OrderDomain.AggregateModels.BuyerModels;
using OrderDomain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            if (notification.Order.BuyerId == 0)
            {
                var buyer =new Buyer(notification.BuyerFirstName, notification.BuyerLastName);
                //buyerRepository.add(buyer);
            }
        }
    }
}
