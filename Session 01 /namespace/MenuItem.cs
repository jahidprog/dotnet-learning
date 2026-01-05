namespace RestaurantApp
{
    // Represents a food item on the menu
    public class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }  // Appetizer, Main Course, Dessert
        public int PreparationTime { get; set; }  // in minutes

        public MenuItem(string name, decimal price, string category, int prepTime)
        {
            Name = name;
            Price = price;
            Category = category;
            PreparationTime = prepTime;
        }

        public void DisplayMenuItem()
        {
            Console.WriteLine($"  {Name} - ${Price} ({Category}) - {PreparationTime} min");
        }
    }
}