namespace Lesson5_6_extra.Interfaces
{
    internal interface IDrinkItem : IMenuItem
    {
        /// <summary>
        /// Объем в литрах
        /// </summary>
        decimal VolumeLiters { get; }
    }
}
