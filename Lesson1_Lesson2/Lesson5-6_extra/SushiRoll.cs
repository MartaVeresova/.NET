using Lesson5_6_extra.Enums;
using Lesson5_6_extra.Interfaces;

namespace Lesson5_6_extra
{
    internal class SushiRoll : IFoodItem
    {
        private const int defaultWeight = 150;

        private const int defaultSauseWeight = 20;

        public string[] Ingredients { get; }

        public SauseType Sause { get; }

        #region Implement IFoodItem

        public string Name { get; }

        public decimal BasePrice { get; }

        public decimal Price
        {
            get
            {
                return BasePrice + (int)Sause;
            }
        }

        public int WeightGrams
        {
            get
            {
                return defaultWeight + (Sause != SauseType.None ? defaultSauseWeight : 0);
            }
        }

        public string GetDescription()
        {
            return $"'{Name}', {WeightGrams}г, {GetIngredientsNames()}, {GetSauseName()} - {Price}р";
        }

        #endregion

        public SushiRoll(string name, decimal basePrice, SauseType sause, string[] ingredients)
        {
            Name = name;
            BasePrice = basePrice;
            Sause = sause;
            Ingredients = ingredients;
        }

        private string GetIngredientsNames()
        {
            return Ingredients.Length > 0 ? $"с {string.Join(", ", Ingredients)}" : "";
        }

        private string GetSauseName()
        {
            switch (Sause)
            {
                case SauseType.Soy:
                    return nameof(SauseType.Soy);

                case SauseType.Wasabi:
                    return nameof(SauseType.Wasabi);

                case SauseType.Sweet:
                    return nameof(SauseType.Sweet);

                default:
                    return "";
            }
        }
    }
}
