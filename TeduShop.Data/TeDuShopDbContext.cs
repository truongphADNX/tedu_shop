using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data
{
    public class TeDuShopDbContext : DbContext
    {
        public TeDuShopDbContext() : base("")
        {

        }
    }
}
