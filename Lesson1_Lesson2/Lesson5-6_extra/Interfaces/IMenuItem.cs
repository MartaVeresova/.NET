namespace Lesson5_6_extra.Interfaces
{
    internal interface IMenuItem
    {
        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Цена
        /// </summary>
        decimal Price { get; }

        /// <summary>
        /// Базовая Цена
        /// </summary>
        decimal BasePrice { get; }

        /// <summary>
        /// Получить общее описание
        /// </summary>
        /// <returns> Общее описание меню </returns>
        string GetDescription();
    }
}
