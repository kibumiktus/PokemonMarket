﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMarket.Core.Model
{
    public class OrderFeed
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int Count { get; set; }

        public DateTime? ReqestTime { get; set; }
    }
}
