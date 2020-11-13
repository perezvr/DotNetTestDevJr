using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task3Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task3.GetSum(new List<int> { 1, 4, 3, 7, 12 });

            if (result != 27)
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            var result = Task3.GetSum(new List<int> { 1, 4, 3, -3, -6, -0, 7, 12 });

            if (result != 27)
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task3.GetSum(new List<int> { -21, -43 - 654, 0, 0, 0, 0, 4, 3, 7, 8, 9, });

            if (result != 31)
                Assert.Fail();
        }

        [TestMethod]
        public void Test4()
        {
            var result = Task3.GetSum(new List<int> { 100, 200, 300, 400 });

            if (result != 1000)
                Assert.Fail();
        }

        [TestMethod]
        public void Test5()
        {
            var result = Task3.GetSum(new List<int> { -3, -7, -20, 0 });

            if (result != 0)
                Assert.Fail();
        }

        [TestMethod]
        public void Test6()
        {
            var result = Task3.GetSum(new List<int> { -1, 1, -2, 2, -3, 3 });

            if (result != 6)
                Assert.Fail();
        }
    }
}
