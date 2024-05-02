using OrderDomain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDomain.AggregateModels.OrderModels
{
    public class OrderItem:BaseEntity
    {
        public int  Quantity { get; set; }
        public decimal Price { get; set; }

        public int  ProductId { get; set; }

        public OrderItem(int quantity, decimal price, int productId)
        {
            Quantity = quantity;
            Price = price;
            ProductId = productId;
        }
    }
}
