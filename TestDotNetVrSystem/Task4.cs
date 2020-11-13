using System.Collections.Generic;
using TestDotNetVrSystem.HelpClasses;
namespace TestDotNetVrSystem
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth()
        {
            Repository Repo = new Repository();
            List <Student> studentsThisYear = new List<Student>();
            int i;
            int year = 2020;


            for (i=0; i< Repo.Students.Count; i++)
                if(Repo.Students[i].Birth.Year == year) 
                    studentsThisYear.Add(Repo.Students[i]);
                
                    
            return studentsThisYear;


        }
    }
}
