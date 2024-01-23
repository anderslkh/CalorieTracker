using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class NutritionalTable
    {
        public double EnergyKJ { get; set; } = -1;
        public double EnergyKcal { get; set; } = -1;
        public double Fat { get; set; } = -1;
        public double FatSaturated { get; set; } = -1;
        public double Carbohydrates { get; set; } = -1;
        public double Sugars { get; set; } = -1;
        public double DietaryFibers { get; set; } = -1;
        public double Protein { get; set; } = -1;
        public double Salt { get; set; } = -1;
    }
}
