using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using NetCoreShop.Data.Repositories;
using NetCoreShop.Service;
using Xunit;

namespace NetCoreShop.Test.Service
{
    public class ServiceTesting
    {
        [Fact]
        public void ServiceTestWorks()
        {
            var repo = new Mock<IRepositoryTest>();

            //a
            var service = new NetCoreShop.Service.ServiceTest(repo.Object);
            
            //a
            var str = service.Test();

            //a
            Assert.Equal("Test", str);
        }
    }
}
