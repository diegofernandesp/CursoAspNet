using CursoAspNet.Domain.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Orders
{
    public class OrderStorer
    {
        private readonly IRepository<Order> _OrderRepository;
        private readonly IRepository<Item> _itemRepository;

        public OrderStorer (IRepository<Order> orderRepository, IRepository<Item> itemRepository)
        {
            _OrderRepository = orderRepository;
            _itemRepository = itemRepository;
        }

        public void Store(int id, int itemId, string nuor, DateTime dorg, DateTime dtrc, double qtnc)
        {
            var item = _itemRepository.GetById(itemId);
            DomainException.When(item == null, "Invalid Item");

            var order = _OrderRepository.GetById(id);
            if(order == null)
            {
                order = new Order(nuor, item, dorg, dtrc, qtnc);
                _OrderRepository.Save(order);
            }
            else
            {
                order.Update(nuor, item, dorg, dtrc, qtnc);
            }
        }
    }
}
