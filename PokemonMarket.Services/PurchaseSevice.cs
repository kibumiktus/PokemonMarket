using PokemonMarket.Core.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace PokemonMarket.Services
{
    public class PurchaseSevice
    {
        protected string connectionString;

        public PurchaseSevice() : this(ConfigurationManager.ConnectionStrings["PokemonMarketDB"].ConnectionString)
        {

        }

        public PurchaseSevice(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Save(Purchase entity)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query("Insert into Purchase (Email, Phone, Name, RequestTime) values(@email, @Phone, @Name, GetDate() )", entity);
            }
        }

        public IEnumerable<OrderFeed> ListPurchases(DateTime? minTime)
        {
            IEnumerable<OrderFeed> result;
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                result = db.Query<OrderFeed>(@" select GroupedPurchase.*, p.Name from 
                  (select Email, count(Email) [Count], max([RequestTime]) ReqestTime from Purchase p group by Email ) 
                    GroupedPurchase join Purchase p  on p.Email = GroupedPurchase.Email and p.RequestTime = GroupedPurchase.ReqestTime
					where GroupedPurchase.ReqestTime > @minTime ", new { minTime = minTime });
            }
            return result;
        }
    }
}