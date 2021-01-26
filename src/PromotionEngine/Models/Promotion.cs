using System.Collections.Generic;

namespace PromotionEngine.Models
{
    internal class Promotion
    {
        public string Name { get; }
        public List<UnitQuantity> UnitQuantities { get; }
        public int Price { get; }
        public bool IsActive;

        public Promotion(string name, List<UnitQuantity> unitQuantities, int price)
        {
            Name = name;
            UnitQuantities = unitQuantities;
            Price = price;
            IsActive = true;
        }
    }
}