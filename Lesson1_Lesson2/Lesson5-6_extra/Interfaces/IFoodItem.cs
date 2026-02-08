namespace Lesson5_6_extra.Interfaces
{
    internal interface IFoodItem : IMenuItem
    {
        /// <summary>
        /// Вес в граммах
        /// </summary>
        int WeightGrams { get; }
    }
}
