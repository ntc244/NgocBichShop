using NgocBichShop.Data.Infrastructure;
using NgocBichShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Repositories
{
        public interface IProductRepository : IRepository<Product>
        {

        }
        public class ProductRepository : RepositoryBase<Product>, IProductRepository
        {
            public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
            {

            }
        }
}
