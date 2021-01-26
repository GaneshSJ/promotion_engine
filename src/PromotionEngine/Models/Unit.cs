namespace PromotionEngine.Models
{
    public class Unit
    {
        public char Name { get; }
        public int Price { get; }

        public Unit(char name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}