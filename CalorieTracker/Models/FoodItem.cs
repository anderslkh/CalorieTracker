using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class FoodItem
    {
        public string Name { get; set; } = "DEFAULT";
        public string Brand { get; set; } = "DEFAULT";
        public string ImageLink { get; set; } = "DEFAULT";
        public double? Weight { get; set; } = null;
        public double? Volume { get; set; } = null;
        public bool Favorite { get; set; } = false;
        public string Ingredients { get; set; } = "DEFAULT";
        public NutritionalTable NutritionalTable { get; set; } = new();
    }
}
