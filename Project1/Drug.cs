using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Drug : Pharmacy
    {
        private string availabilityInStock;
        private string bbd;

        public Drug(string name, string manufacturer, string availabilityInStock, string bbd) : base(name, manufacturer) 
        {
            this.availabilityInStock = availabilityInStock;
            this.bbd = bbd;
        }

        public string AvailabilityInStock { get => availabilityInStock; set => availabilityInStock = value; }
        public string BBD { get => BBD; set => BBD = value; }

        public override string Display()
        {
            return "Препарат: \n " + base.Display() + "\n" + "Наличие на складе: " + availabilityInStock + " Срок годности: " + bbd;
        }
    }
}
