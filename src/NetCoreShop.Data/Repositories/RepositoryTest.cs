using System.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using NetCoreShop.Data.Infrastructure;
using NetCoreShop.Data.Models;

namespace NetCoreShop.Data.Repositories
{
    public class RepositoryTest : RepositoryBase<TestModel>, IRepositoryTest
    {
        public RepositoryTest(IDbContextFactory<NetCoreShopContext> factory) : base(factory)
        {
            if (!DbSet.Any())
            {
                DbSet.Add(new TestModel
                {
                    Data = "Testowy wpis"
                });
                Context.SaveChanges();
            }
        }
    }

    public interface IRepositoryTest : IRepository<TestModel>
    {
    }
}