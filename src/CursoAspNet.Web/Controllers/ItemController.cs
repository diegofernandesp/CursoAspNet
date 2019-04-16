using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoAspNet.Domain.Items;
using CursoAspNet.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CursoAspNet.Web.Controllers
{
    public class ItemController : Controller
    {
        private readonly ItemStorer _ItemStorer;

        public ItemController(ItemStorer itemStorer)
        {
            _ItemStorer = itemStorer;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
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
