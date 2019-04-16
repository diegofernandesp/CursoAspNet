using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoAspNet.Domain;
using CursoAspNet.Domain.Items;
using CursoAspNet.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CursoAspNet.Web.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemStorer _ItemStorer;

        private IRepository<Item> _ItemRepository;

        public ItemController(ItemStorer itemStorer, IRepository<Item> itemRepository)
        {
            _ItemStorer = itemStorer;
            _ItemRepository = itemRepository;
        }
        public IActionResult Index()
        {
            var items = _ItemRepository.All();
            var ViewModel = items.Select(i => new ItemViewModel { Id = i.Id, Citm = i.Citm, Ditm = i.Ditm, Poor = i.Poor, Qtdp = i.Qtdp });
            return View(ViewModel);
        }

        public IActionResult CreateOrEdit(int id)
        {
            if (id > 0)
            {
                var item = _ItemRepository.GetById(id);
                var viewModel = new ItemViewModel { Id = item.Id, Citm = item.Citm, Ditm = item.Ditm, Poor = item.Poor, Qtdp = item.Qtdp };
                return View(viewModel);
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(ItemViewModel item)
        {
            _ItemStorer.Store(item.Id, item.Citm, item.Ditm, item.Qtdp, item.Poor);
            return RedirectToAction("Index");
        }
    }
}
