using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NgocBichShopDbContext dbContext;

        public NgocBichShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NgocBichShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
