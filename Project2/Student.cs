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
        private string surname;
        private string group;
        private int[] academicPerformance;

        public Student(string name = "Ivan", string surname = "Ivanov", string group = "1")
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
            academicPerformance = new int[50];
            for (int i = 0; i < 50; i++)
            {
                academicPerformance[i] = IntUtil.Random(2, 6);
            }
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Group { get => group; set => group = value; }
        public int[] AcademicPerformance { get => academicPerformance; }

        public double averageValue()
        {
            return academicPerformance.Average();
        }
    }
}
