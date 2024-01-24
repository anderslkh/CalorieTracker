namespace Models
{
    public class FoodItem
    {
        public int Id { get; }
        public string Name { get; set; } = "DEFAULT";
        public string Brand { get; set; } = "DEFAULT";
        public string ImageLink { get; set; } = "DEFAULT";
        public float? Weight { get; set; } = null;
        public float? Volume { get; set; } = null;
        public bool Favorite { get; set; } = false;
        public string Ingredients { get; set; } = "DEFAULT";
        public NutritionalTable NutritionalTable { get; set; } = new();
    }
}
