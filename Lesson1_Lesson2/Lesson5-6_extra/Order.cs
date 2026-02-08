using Lesson5_6_extra.Interfaces;

namespace Lesson5_6_extra
{
    internal class Order
    {
        public List<IMenuItem> Items { get; } = new List<IMenuItem>();

        public void AddItem(IMenuItem item) => Items.Add(item);

        public decimal GetTotal() => Math.Truncate(Items.Sum(x => x.Price));

        public void PrintReceipt()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.GetDescription());
            }

            Console.WriteLine($"ИТОГО: {GetTotal()}р");
        }

    }
}
