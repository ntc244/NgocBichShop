using NgocBichShop.Data.Infrastructure;
using NgocBichShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post> { }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        protected PostRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
