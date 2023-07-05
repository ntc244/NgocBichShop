using NgocBichShop.Data.Infrastructure;
using NgocBichShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        protected MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
