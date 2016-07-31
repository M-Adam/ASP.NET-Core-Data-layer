using Xunit;

namespace NetCoreShop.Test.Web.Common
{
    public class FirstTest
    {
        [Fact]
        public void TwoPlusTwoEqualsFour()
        {
            var result = 2 + 2;

            Assert.Equal(4, result);
        }
        
    }
}
