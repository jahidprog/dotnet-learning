using System;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║        WELCOME TO LA MAISON RESTAURANT         ║");
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine();

            // ===== STEP 1: Create the Restaurant Staff =====
            Chef chef = new Chef("Gordon", "Italian Cuisine");
            Waiter waiter = new Waiter("Michael");

            chef.DisplayChefInfo();

            // ===== STEP 2: Create the Menu =====
            List<MenuItem> menu = new List<MenuItem>
            {
                new MenuItem("Caesar Salad", 8.99m, "Appetizer", 5),
                new MenuItem("Tomato Soup", 6.99m, "Appetizer", 7),
                new MenuItem("Grilled Salmon", 24.99m, "Main Course", 15),
                new MenuItem("Beef Steak", 29.99m, "Main Course", 20),
                new MenuItem("Margherita Pizza", 18.99m, "Main Course", 12),
                new MenuItem("Tiramisu", 7.99m, "Dessert", 5),
                new MenuItem("Chocolate Cake", 6.99m, "Dessert", 5)
            };

            // ===== STEP 3: Customer Arrives =====
            Customer customer1 = new Customer("Alice", 5);
            
            waiter.Greet(customer1);
            waiter.ShowMenu(menu);

            // ===== STEP 4: Customer Places Order =====
            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine("            ORDERING PHASE");
            Console.WriteLine(new string('-', 50));
            
            waiter.TakeOrder(customer1, menu[0]);  // Caesar Salad
            waiter.TakeOrder(customer1, menu[3]);  // Beef Steak
            waiter.TakeOrder(customer1, menu[5]);  // Tiramisu

            // ===== STEP 5: Waiter Sends Order to Kitchen =====
            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine("            KITCHEN PHASE");
            Console.WriteLine(new string('-', 50));
            
            waiter.SendOrderToKitchen(customer1, chef);

            // ===== STEP 6: Chef Cooks the Food =====
            chef.CookFood(customer1);

            // ===== STEP 7: Waiter Serves the Food =====
            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine("            SERVING PHASE");
            Console.WriteLine(new string('-', 50));
            
            waiter.ServeFood(customer1);

            // ===== STEP 8: Customer Finishes and Pays =====
            Console.WriteLine("\n" + new string('-', 50));
            Console.WriteLine("            PAYMENT PHASE");
            Console.WriteLine(new string('-', 50));
            
            waiter.BringBill(customer1);
            customer1.PayBill();

            // ===== STEP 9: Goodbye =====
            Console.WriteLine($"\n Waiter {waiter.Name}: Thank you for dining with us, {customer1.Name}!");
            Console.WriteLine($" Chef {chef.Name}: Hope you enjoyed the meal!");
            
            Console.WriteLine("\n╔════════════════════════════════════════════════╗");
            Console.WriteLine("  ║             COME AGAIN SOON!                   ║");
            Console.WriteLine("  ╔════════════════════════════════════════════════╗");
        }
    }
}
