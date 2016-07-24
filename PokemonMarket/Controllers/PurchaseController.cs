using AutoMapper;
using PokemonMarket.Core.Model;
using PokemonMarket.Services;
using PokemonMarket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokemonMarket.Controllers
{
    public class PurchaseController : Controller
    {
        PurchaseSevice _service;
        public PurchaseController()
        {
            _service = new PurchaseSevice();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PurchaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var purchase = Mapper.Map<Purchase>(model);
                    _service.Save(purchase);
                    return RedirectToAction("Index", "OrderFeed");
                }
                catch 
                {
                    ModelState.AddModelError("PurchaseNotSaved", "Purchase not saved");
                }
            }
            return View(model);
        }
    }
}