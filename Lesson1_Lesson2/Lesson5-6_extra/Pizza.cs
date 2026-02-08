using Lesson5_6_extra.Enums;
using Lesson5_6_extra.Interfaces;

namespace Lesson5_6_extra
{
    internal class Pizza : IFoodItem
    {
        private const int defaultSize = 300;

        public PizzaSize Size { get; }

        public string[] Toppings { get; }

        #region Implement IFoodItem

        public string Name { get; }

        public decimal BasePrice { get; }

        public decimal Price
        {
            get
            {
                return BasePrice + (int)Size;
            }
        }

        public int WeightGrams
        {
            get
            {
                return defaultSize + (int)Size;
            }
        }

        public string GetDescription()
        {
            return $"'{Name}', ({GetSizeName()}, {WeightGrams}г) {GetToppings()} - {Price}р";
        }

        #endregion

        public Pizza(string name, decimal basePrice, PizzaSize size, string[]? toppings = null)
        {
            Name = name;
            BasePrice = basePrice;
            Size = size;
            Toppings = toppings == null ? [] : toppings;

        }

        private string GetSizeName()
        {
            switch (Size)
            {
                case PizzaSize.Small:
                    return nameof(PizzaSize.Small);

                case PizzaSize.Medium:
                    return nameof(PizzaSize.Medium);

                case PizzaSize.Large:
                    return nameof(PizzaSize.Large);

                default:
                    return "";
            }
        }

        private string GetToppings()
        {
            return Toppings.Length > 0 ? $"с {string.Join(", ", Toppings)}" : "";
        }
    }
}
