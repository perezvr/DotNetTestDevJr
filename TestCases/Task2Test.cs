using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace TestCases
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task2.CheckInput("ABC1239a");

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

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test5()
        {
            var result = Task2.CheckInput("zzz0000A");

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test6()
        {
            var result = Task2.CheckInput("AZQ0000'");

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test7()
        {
            var result = Task2.CheckInput("z*z099zx");

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test8()
        {
            var result = Task2.CheckInput("_=A1234");

            if (result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test9()
        {
            var result = Task2.CheckInput("QWE1020x");

            if (!result)
                Assert.Fail();
        }

        [TestMethod]
        public void Test10()
        {
            var result = Task2.CheckInput("QWE1020Z");

            if (result)
                Assert.Fail();
        }
    }
}
