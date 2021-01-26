using System.Collections.Generic;

namespace PromotionEngine.Models
{
    internal class Promotion
    {
        public IList<UnitQuantity> UnitQuantities;
        public int Price;
        public bool IsActive;
    }
}