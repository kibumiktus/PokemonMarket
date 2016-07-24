using AutoMapper;
using PokemonMarket.Core.Model;
using PokemonMarket.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMarket.App_Start
{
    public class MapperConfig
    {
        public static void RegisterConfig()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<PurchaseViewModel, Purchase>();
                cfg.CreateMap<OrderFeed,OrderFeedViewModel>();
            });                       
        }
    }
}