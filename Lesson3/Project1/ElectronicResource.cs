using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ElectronicResource : Pharmacy
    {
        private string readings;

        public ElectronicResource(string name, string manufacturer, string readings) : base(name, manufacturer)
        {
            this.readings = readings;
        }

        public string Readings { get => readings; set => readings = value; }

        public override string Display()
        {
            return "Электронный резурс: \n " + base.Display() + "\n " + "Показания: " + readings;
        }
    }
}
