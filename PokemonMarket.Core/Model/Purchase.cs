using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonMarket.Core.Model
{
    public class Purchase
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime? ReqestTime { get; set; }
    }
}
