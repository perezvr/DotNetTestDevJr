using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDotNetVrSystem;

namespace TestCases
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task2.CheckInput("ABC1239");

            if (!result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test2()
        {
            var result = Task2.CheckInput("ABC-5639");

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test3()
        {
            var result = Task2.CheckInput("ARx5639");

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test4()
        {
            var result = Task2.CheckInput("ARR0000");

            if (!result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test5()
        {
            var result = Task2.CheckInput("zzz0000");

            if (result)
                Assert.Fail();
        }
    }
}
