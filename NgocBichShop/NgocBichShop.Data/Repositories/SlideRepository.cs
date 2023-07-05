using NgocBichShop.Data.Infrastructure;
using NgocBichShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide> { }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        protected SlideRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
