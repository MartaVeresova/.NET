using Lesson5_6_extra;
using Lesson5_6_extra.Enums;

namespace Practice
{
    internal class Example
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.AddItem(new Pizza("Маргарита", 350m, PizzaSize.Medium, ["сыр", "томат"]));
            order.AddItem(new SushiRoll("Филадельфия", 350m, SauseType.Wasabi, ["лосось", "сыр"]));
            order.AddItem(new Drink("Кола", 100m, 0.5m, true));
            order.AddItem(new Drink("Сок", 80m, 1.0m, false));

            order.PrintReceipt();
        }
    }
}