using NgocBichShop.Data.Infrastructure;
using NgocBichShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocBichShop.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order> { }
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        protected OrderRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
