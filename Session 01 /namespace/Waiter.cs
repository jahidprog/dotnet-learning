
namespace RestaurantApp
{
    // Represents a waiter who takes orders and serves food
    public class Waiter
    {
        public string Name { get; set; }

        public Waiter(string name)
        {
            Name = name;
        }

        public void Greet(Customer customer)
        {
            Console.WriteLine($"\n Waiter {Name}: Welcome {customer.Name}! Your table number is {customer.TableNumber}.");
            Console.WriteLine($" Waiter {Name}: Here is our menu today!");
        }

        public void ShowMenu(List<MenuItem> menu)
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("               🍴 TODAY'S MENU 🍴");
            Console.WriteLine(new string('=', 50));
            
            foreach (var item in menu)
            {
                item.DisplayMenuItem();
            }
            
            Console.WriteLine(new string('=', 50));
        }

        public void TakeOrder(Customer customer, MenuItem item)
        {
            Console.WriteLine($"\n Waiter {Name}: Got it! One {item.Name} for table {customer.TableNumber}.");
            customer.PlaceOrder(item);
        }

        public void SendOrderToKitchen(Customer customer, Chef chef)
        {
            Console.WriteLine($"\n Waiter {Name}: Sending order to the kitchen...");
            chef.ReceiveOrder(customer);
        }

        public void ServeFood(Customer customer)
        {
            Console.WriteLine($"\n Waiter {Name}: Here is your food, {customer.Name}! Enjoy your meal! 🍽️");
            Console.WriteLine($" Waiter {Name}: Please let me know if you need anything else.");
        }

        public void BringBill(Customer customer)
        {
            decimal total = customer.GetTotalBill();
            Console.WriteLine($"\n Waiter {Name}: Here is your bill: ${total}");
        }
    }
}