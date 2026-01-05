

namespace RestaurantApp
{
    // Represents a customer who orders food
    public class Customer
    {
        public string Name { get; set; }
        public int TableNumber { get; set; }
        public List<MenuItem> Order { get; set; }

        public Customer(string name, int tableNumber)
        {
            Name = name;
            TableNumber = tableNumber;
            Order = new List<MenuItem>();
        }

        public void PlaceOrder(MenuItem item)
        {
            Order.Add(item);
            Console.WriteLine($" {Name} (Table {TableNumber}): I would like to order {item.Name}!");
        }

        public void ViewOrder()
        {
            Console.WriteLine($"\n Order for {Name} (Table {TableNumber}):");
            decimal total = 0;
            
            foreach (var item in Order)
            {
                Console.WriteLine($"   - {item.Name}: ${item.Price}");
                total += item.Price;
            }
            
            Console.WriteLine($"   Total: ${total}");
        }

        public decimal GetTotalBill()
        {
            decimal total = 0;
            foreach (var item in Order)
            {
                total += item.Price;
            }
            return total;
        }

        public void PayBill()
        {
            decimal total = GetTotalBill();
            Console.WriteLine($"\n {Name} is paying ${total}...");
            Console.WriteLine($"✓ Payment successful! Thank you {Name}!");
        }
    }
}