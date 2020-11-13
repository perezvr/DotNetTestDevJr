using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Tasks;
using Tasks.HelpClasses;

namespace TestCases
{
    [TestClass]
    public class Task4Test
    {
        [TestMethod]
        public void Test1()
        {
            var result = Task4.GetStudentsByBirth();
            var repository = new Repository();

            result = result.OrderBy(i => i.Id).ToList();

            List<int> matchIds = new List<int>() { 1, 12 };

            if (matchIds.Except(result.Select(i => i.Id)).Any() || result.Select(i => i.Id).Except(matchIds).Any())
                Assert.Fail();
        }
    }
}
