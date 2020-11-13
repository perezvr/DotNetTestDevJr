using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task1Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task1.GetMax(new List<int> { 1, 4, 3, 7, 12 });

            if (result != 12)
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            var result = Task1.GetMax(new List<int> { 23, -25, 56, -43 });

            if (result != 56)
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task1.GetMax(new List<int> { -1000, 2, -23423, -232322, 0 });

            if (result != 2)
                Assert.Fail();
        }

        [TestMethod]
        public void Test4()
        {
            var result = Task1.GetMax(new List<int> { 1, 1, 2, 2 });

            if (result != 2)
                Assert.Fail();
        }

        [TestMethod]
        public void Test5()
        {
            var result = Task1.GetMax(new List<int> { -20, -22, -232332, -11 });

            if (result != -11)
                Assert.Fail();
        }
    }
}
