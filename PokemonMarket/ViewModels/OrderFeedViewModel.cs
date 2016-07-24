using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonMarket.ViewModels
{
    public class OrderFeedViewModel
    {
        public string Name { get; set; }

        public DateTime ReqestTime { protected get; set; }

        public int Count { get; set; }

        public string ReqestTimeString { get { return this.ReqestTime.ToString("hh.mm dd.MM.yyyy"); } }
    }
}