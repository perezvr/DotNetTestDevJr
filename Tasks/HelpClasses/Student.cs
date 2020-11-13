using System;

namespace Tasks.HelpClasses
{
    public class Student
    {
        public Student(int id, string name, DateTime birth)
        {
            Id = id;
            Name = name;
            Birth = birth;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
    }
}
