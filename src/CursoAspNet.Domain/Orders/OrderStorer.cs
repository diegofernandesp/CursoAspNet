using CursoAspNet.Domain.Dto;
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

        public void Store(OrderDto dto)
        {
            var item = _itemRepository.GetById(dto.ItemId);
            DomainException.When(item == null, "Invalid Item");

            var order = _OrderRepository.GetById(dto.Id);
            if(order == null)
            {
                order = new Order(dto.Nuor, item, dto.Dorg, dto.Dtrc, dto.Qtnc);
                _OrderRepository.Save(order);
            }
            else
            {
                order.Update(dto.Nuor, item, dto.Dorg, dto.Dtrc, dto.Qtnc);
            }
        }
    }
}
