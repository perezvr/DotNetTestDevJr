using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task7Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task7.GetProductsOutOfStock();
            List<string> matchNames = new List<string>() { "Product0", "Product4", "Product8", "Product12", "Product16", };

            if (matchNames.Except(result).Any() || result.Except(matchNames).Any())
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            var result = Task7.GetSumStock();

            if (result != 6500)
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task7.IsSalePossible(1, 200);

            if (!result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test4()
        {
            var result = Task7.IsSalePossible(0, 10);

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test5()
        {
            var result = Task7.IsSalePossible(3, 601);

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test6()
        {
            var result = Task7.IsSalePossible(5, 150);

            if (!result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test7()
        {
            var result = Task7.IsSalePossible(6, 500);

            if (!result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test8()
        {
            var result = Task7.IsSalePossible(6, 501);

            if (result)
                Assert.Fail();
        }
    }
}
