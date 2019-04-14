using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoAspNet.Domain.Dto;
using CursoAspNet.Domain.Items;
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
        public IActionResult CreateOrEdit(ItemDto dto)
        {
            _ItemStorer.Store(dto);
            return View();
        }
    }
}