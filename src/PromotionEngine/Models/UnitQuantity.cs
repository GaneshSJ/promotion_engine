namespace PromotionEngine.Models
{
    public class UnitQuantity
    {
        public Unit Unit { get; }
        public int Quantity { get; }

        public UnitQuantity(Unit unit, int quantity = 1)
        {
            Unit = unit;
            Quantity = quantity;
        }
    }
}