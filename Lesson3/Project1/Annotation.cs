using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Annotation : Pharmacy
    {
        private string activeSubstance;
        private string dailyDose;
        private string durationOfReception;

        public Annotation(string name, string manufacturer, string activeSubstance, string dailyDose, string durationOfReception) : base(name, manufacturer)
        {
            this.activeSubstance = activeSubstance;
            this.dailyDose = dailyDose;
            this.durationOfReception = durationOfReception;
        }

        public string ActiveSubstance { get => activeSubstance; set => activeSubstance = value; }
        public string DailyDose { get => dailyDose; set => dailyDose = value; }
        public string DurationOfReception { get => durationOfReception; set => durationOfReception = value; }

        public override string Display()
        {
            return "Аннотация: \n " + base.Display() + "\n " + "Действующее вещество: " + activeSubstance + " Суточная доза: " + dailyDose + " Продолжительность приема: " + dailyDose;
        }
    }
}
