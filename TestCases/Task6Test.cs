using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task6Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task6.GetRatios(new List<int>() { -4, 3, -9, 0, 4, 1 });

            if (result[0] != 0.500000m)
                Assert.Fail();

            if (result[1] != 0.333333m)
                Assert.Fail();

            if (result[2] != 0.166667m)
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            var result = Task6.GetRatios(new List<int>() { -3, -2, -1, 0, 1, 2 });

            if (result[0] != 0.333333m)
                Assert.Fail();

            if (result[1] != 0.500000m)
                Assert.Fail();

            if (result[2] != 0.166667m)
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task6.GetRatios(new List<int>() { 3, 2, 1, -1, -2, -3 });

            if (result[0] != 0.500000m)
                Assert.Fail();

            if (result[1] != 0.500000m)
                Assert.Fail();

            if (result[2] != 0.000000m)
                Assert.Fail();
        }

        [TestMethod]
        public void Test4()
        {
            var result = Task6.GetRatios(new List<int>() { 0, 0, 0, 0, 0, 0, 1, 2, 3, 5 });

            if (result[0] != 0.400000m)
                Assert.Fail();

            if (result[1] != 0.000000m)
                Assert.Fail();

            if (result[2] != 0.600000m)
                Assert.Fail();
        }

        [TestMethod]
        public void Test5()
        {
            var result = Task6.GetRatios(new List<int>() { 0, 1, 2, 3, 0, 0, 0, -4, -5, -6 });

            if (result[0] != 0.300000m)
                Assert.Fail();

            if (result[1] != 0.300000m)
                Assert.Fail();

            if (result[2] != 0.400000m)
                Assert.Fail();
        }

        [TestMethod]
        public void Test6()
        {
            var result = Task6.GetRatios(new List<int>() { 120213, 123125, 565462, 65774456, 36546456, 0, 0, 0, -34125, -524352 });

            if (result[0] != 0.500000m)
                Assert.Fail();

            if (result[1] != 0.200000m)
                Assert.Fail();

            if (result[2] != 0.300000m)
                Assert.Fail();
        }
    }
}