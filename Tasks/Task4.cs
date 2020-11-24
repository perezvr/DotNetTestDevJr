using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<student> GetStudentsByBirth()
        {
            var repository = new Repository();
            List<student> students = new List<student>();
            var result = Enumerable.Range(0, students.Count)
             .Select(id => students[id].Birth.Year == 2020)
             .ToList();
            return result;

        }
    }
}
