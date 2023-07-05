using NgocBichShop.Data.Infrastructure;
using NgocBichShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page> { }
    public class PageRepository : RepositoryBase<Page>
    {
        protected PageRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
