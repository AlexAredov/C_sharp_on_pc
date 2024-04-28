using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKBfront
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        public string DateOfBirth { get; set; }
        public string MKBnumber { get; set; }
        public string MKBname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
    }
}
