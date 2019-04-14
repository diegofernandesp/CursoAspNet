using CursoAspNet.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Items
{
    public class ItemStorer
    {
        private readonly IRepository<Item> _ItemRepository;

        public ItemStorer(IRepository<Item> itemRepository)
        {
            _ItemRepository = itemRepository;
        }

        public void Store (ItemDto dto)
        {
            var item = _ItemRepository.GetById(dto.Id);
            if (item == null)
            {
                item = new Item(dto.Citm, dto.Ditm, dto.Qtdp, dto.Poor);
                _ItemRepository.Save(item);
            }
            else
                item.Update(dto.Citm, dto.Ditm, dto.Qtdp, dto.Poor);
        }
    }
}
