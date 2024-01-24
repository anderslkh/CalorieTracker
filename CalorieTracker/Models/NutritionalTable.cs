namespace Models
{
    public class NutritionalTable
    {
        public int Id { get; }
        public float EnergyKJ { get; set; } = -1;
        public float EnergyKcal { get; set; } = -1;
        public float Fat { get; set; } = -1;
        public float FatSaturated { get; set; } = -1;
        public float Carbohydrates { get; set; } = -1;
        public float Sugars { get; set; } = -1;
        public float DietaryFibers { get; set; } = -1;
        public float Protein { get; set; } = -1;
        public float Salt { get; set; } = -1;
    }
}
