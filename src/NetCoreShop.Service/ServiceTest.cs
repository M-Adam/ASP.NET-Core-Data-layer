using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using NetCoreShop.Data;
using NetCoreShop.Data.Models;
using NetCoreShop.Data.Repositories;

namespace NetCoreShop.Service
{
    public class ServiceTest : ServiceBase, IServiceTest
    {
        private readonly IRepositoryTest _repoTest;

        public ServiceTest(IRepositoryTest repoTest)
        {
            this._repoTest = repoTest;
        }

        public string Test()
        {
            return "Test";
        }

        public TestModel ContextTest()
        {
            return _repoTest.GetAll().First();
        }

        public IEnumerable<TestModel> GetAll()
        {
            return _repoTest.GetAll();
        }
    }

    public interface IServiceTest
    {
        string Test();

        TestModel ContextTest();

        IEnumerable<TestModel> GetAll();
    }

    

    
}
