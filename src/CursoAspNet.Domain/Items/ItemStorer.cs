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

        public void Store (int id, string citm, string ditm, double qtdp, string poor)
        {
            var item = _ItemRepository.GetById(id);
            if (item == null)
            {
                item = new Item(citm, ditm, qtdp, poor);
                _ItemRepository.Save(item);
            }
            else
                item.Update(citm, ditm, qtdp, poor);
        }
    }
}
