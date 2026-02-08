using Lesson5_6_extra.Interfaces;

namespace Lesson5_6_extra
{
    internal class Drink : IDrinkItem
    {

        public bool IsCarbonated { get; }

        #region Implement IDrinkItem

        public string Name { get; }

        public decimal VolumeLiters { get; }

        public decimal BasePrice { get; }

        public decimal Price
        {
            get
            {
                return BasePrice + VolumeLiters * 20m;
            }
        }

        public string GetDescription()
        {
            return $"'{Name}', {VolumeLiters}л, {GetCarbonated()} - {Math.Truncate(Price)}р";
        }

        #endregion

        public Drink(string name, decimal basePrice, decimal volumeLiters, bool isCarbonated)
        {
            Name = name;
            BasePrice = basePrice;
            VolumeLiters = volumeLiters;
            IsCarbonated = isCarbonated;
        }

        private string GetCarbonated()
        {
            return IsCarbonated ? "газированная" : "не газированная";
        }
    }
}
