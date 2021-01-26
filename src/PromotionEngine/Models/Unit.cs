using System;

namespace PromotionEngine.Models
{
    public class Unit: IEquatable<Unit>
    {
        public char Name { get; }
        public int Price { get; }

        public Unit(char name, int price)
        {
            Name = name;
            Price = price;
        }

        public bool Equals(Unit other) => other != null && Name.Equals(other.Name);
    }
}