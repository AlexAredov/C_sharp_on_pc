using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class Pharmacy
    {
        private string name;
        private string manufacturer;

        public Pharmacy(string name, string manufacturer)
        {
            this.name = name;
            this.manufacturer = manufacturer;
        }

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Name { get => name; set => name = value; }

        public virtual string Display()
        {
            return "Название: " + name + " Производитель: " + manufacturer;
        }
    }
}
