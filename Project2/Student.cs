using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Student
    {
        private string name;
        private string surname1;
        private string surname2;
        private string group;
        private int[] academicPerformance;
        private Random rand = new Random(0);

        public Student(string name = "Ivan", string surname1 = "Ivanov", string surname2, string group)
        {
            this.Name = name;
            this.Surname1 = surname1;
            this.Surname2 = surname2;
            this.Group = group;
            academicPerformance = new int[10];
            for(int i = 0; i < 10; i++)
            {
                AcademicPerformance[i] = rand.Next(1, 5);
            }
        }

        public string Name { get => name; set => name = value; }
        public string Surname1 { get => surname1; set => surname1 = value; }
        public string Surname2 { get => surname2; set => surname2 = value; }
        public string Group { get => group; set => group = value; }
        public int[] AcademicPerformance { get => academicPerformance; }

        public 
    }
}
