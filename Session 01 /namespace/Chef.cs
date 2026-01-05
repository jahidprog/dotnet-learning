

namespace RestaurantApp
{
    // Represents a chef who cooks the food
    public class Chef
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Chef(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }

        public void ReceiveOrder(Customer customer)
        {
            Console.WriteLine($"\n Chef {Name}: New order received from table {customer.TableNumber}!");
            customer.ViewOrder();
        }

        public void CookFood(Customer customer)
        {
            Console.WriteLine($"\n Chef {Name}: Starting to cook...");
            
            foreach (var item in customer.Order)
            {
                Console.WriteLine($" Chef {Name}: Preparing {item.Name}... (this will take {item.PreparationTime} minutes)");
                
                // Simulate cooking time (using milliseconds for demo - 1 min = 1000ms)
                Thread.Sleep(item.PreparationTime * 100); // Scaled down for demo
                
                Console.WriteLine($" Chef {Name}: ✓ {item.Name} is ready!");
            }
            
            Console.WriteLine($"\n Chef {Name}: All dishes for table {customer.TableNumber} are ready! ");
        }

        public void DisplayChefInfo()
        {
            Console.WriteLine($"\n Head Chef: {Name}");
            Console.WriteLine($" Specialty: {Specialty}");
        }
    }
}