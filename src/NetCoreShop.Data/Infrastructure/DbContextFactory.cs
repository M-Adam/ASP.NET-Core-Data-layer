using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace NetCoreShop.Data.Infrastructure
{
    public class DbContextFactory : IDbContextFactory<NetCoreShopContext>
    {
        private const string Connection = @"Server=(localdb)\MSSQLLocalDB;Database=testDb;Trusted_Connection=True;MultipleActiveResultSets=true";

        private NetCoreShopContext _context;

        public NetCoreShopContext Create(DbContextFactoryOptions options = null)
        {
            if (_context != null)
                return _context;

            var builder = new DbContextOptionsBuilder<NetCoreShopContext>();
            builder.UseSqlServer(Connection);
            _context = new NetCoreShopContext(builder.Options);
            return _context;
        }

        
    }
}