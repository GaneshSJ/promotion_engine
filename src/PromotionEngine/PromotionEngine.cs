using System.Collections.Generic;
using System.Linq;
using PromotionEngine.Models;

namespace PromotionEngine
{
    public class PromotionEngine
    {
        private readonly List<Promotion> _promotions;

        public readonly Unit UnitA = new Unit('A', 50);
        public readonly Unit UnitB = new Unit('B', 30);
        public readonly Unit UnitC = new Unit('C', 20);
        public readonly Unit UnitD = new Unit('D', 15);

        public PromotionEngine()
        {
            _promotions = new List<Promotion>();
            
            var promoUnitA = new List<UnitQuantity> { new UnitQuantity(UnitA, 3) };
            _promotions.Add(new Promotion("Promotion 1", promoUnitA, 130));
            var promoUnitB = new List<UnitQuantity> { new UnitQuantity(UnitB, 2) };
            _promotions.Add(new Promotion("Promotion 2", promoUnitB, 45));
            var promoUnitsCAndD = new List<UnitQuantity> { new UnitQuantity(UnitC), new UnitQuantity(UnitD) };
            _promotions.Add(new Promotion("Promotion 3", promoUnitsCAndD, 30));
        }

        public int CalculateValue(Order order)
        {
            var value = 0;
            _promotions.ForEach(promo =>
            {
                if (!promo.UnitQuantities.All(promoUnitQuantity => order.UnitQuantities.Any(orderUnitQuantity =>
                    promoUnitQuantity.Unit.Name.Equals(orderUnitQuantity.Unit.Name) &&
                    orderUnitQuantity.Quantity <= promoUnitQuantity.Quantity)))
                    return;
                promo.UnitQuantities.ForEach(promoUnitQuantity =>
                    order.UnitQuantities.First(orderUnitQuantity =>
                            promoUnitQuantity.Unit.Name.Equals(orderUnitQuantity.Unit.Name)).Quantity -=
                        promoUnitQuantity.Quantity);
                value += promo.Price;
            });
            order.UnitQuantities.ForEach(unitQuantity => value += unitQuantity.Unit.Price * unitQuantity.Quantity);
            return value;
        }
    }
}