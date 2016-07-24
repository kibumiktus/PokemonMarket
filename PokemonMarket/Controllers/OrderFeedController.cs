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

    public class OrderFeedController : Controller
    {
        PurchaseSevice _service;
        public OrderFeedController()
        {
            _service = new PurchaseSevice();
        }

        [HttpGet]
        // GET: OrderFeed
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult List(DateTime? minTime)
        {

            var listPurchases = _service.ListPurchases(minTime);

            var result = Mapper.Map<IEnumerable<OrderFeed>, IEnumerable<OrderFeedViewModel>>(listPurchases);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}