using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Models
{
    public class Order
    {
        public List<UnitQuantity> UnitQuantities { get; }

        public Order() => UnitQuantities = new List<UnitQuantity>();

        public void Add(Unit unit, int quantity = 1)
        {
            if (UnitQuantities.Any(unitQuantity => unitQuantity.Unit.Name.Equals(unit.Name)))
                throw new System.Exception($"Unit with name \"{unit.Name}\" already added in order.");
            UnitQuantities.Add(new UnitQuantity(unit, quantity));
        }
    }
}