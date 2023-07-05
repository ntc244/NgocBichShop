using NgocBichShop.Data.Infrastructure;
using NgocBichShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag> { }
    public class PostTagRepository : RepositoryBase<PostTag>
    {
        protected PostTagRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
