using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapMakanApp.Class
{
    // Menu class to manage menu details

    // create a food class
    public class Food
    {
        // create a food class with properties
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Id { get; set; }

        // constructor for food class
        public Food(string id, string name, string description, double price, bool isAvailable)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            IsAvailable = isAvailable;
        }
    }



    static class FoodMenu
    {
        // Initialization of menu list
        public static List<Food> menu = new List<Food>();
        // Add generated food to menu without using a function
        static FoodMenu()
        {
            menu.Add(new Food("F01","Nasi Lemak", "A fragrant rice dish cooked in coconut milk, served with sambal, fried anchovies, peanuts, and boiled egg.", 8.50, true));
            menu.Add(new Food("F02", "Roti Canai", "A flaky flatbread served with dhal curry or sugar.", 3.00, true));
            menu.Add(new Food("F03", "Char Kway Teow", "Stir-fried flat rice noodles with prawns, Chinese sausage, and bean sprouts.", 7.00, true));
            menu.Add(new Food("F04", "Laksa", "Spicy noodle soup with coconut milk and shrimp or chicken.", 9.00, true));
            menu.Add(new Food("F05", "Satay", "Grilled skewered meat served with peanut sauce.", 6.00, true));
        }



        // Method to retrieve the menu
        public static List<Food> GetMenu()
        {
            return menu;
        }

        // Method to update availability by id
        public static void UpdateAvailability(string id, bool availability)
        {
            // find the food by id with loop
            foreach (Food food in menu)
            {
                if (food.Id == id)
                {
                    food.IsAvailable = availability;
                    return;
                }
            }
            Console.WriteLine("Food not found");   
        }

        // Method to check food detail
        public static Food GetFood(string id)
        {
            // find the food by id with loop
            foreach (Food food in menu)
            {
                if (food.Id == id)
                {
                    return food;
                }
            }
            Console.WriteLine("Food not found");
            return null;
        }

        // Method to add food to menu by manually reconstructing the food
        public static void AddFood(string id, string name, string description, double price, bool isAvailable)
        {
            // create a new food object
            Food food = new Food(id, name, description, price, isAvailable);
            // add the food to the menu
            menu.Add(food);
        }
        
        // Method to remove food from menu
        public static void RemoveFood(string id)
        {
            // find the food by id with loop
            foreach (Food food in menu)
            {
                if (food.Id == id)
                {
                    menu.Remove(food);
                    return;
                }
            }
            Console.WriteLine("Food not found");
        }
        
        // Method to update food details
        public static void UpdateFood(string id, string name, string description, double price, bool isAvailable)
        {
            // find the food by id with loop
            foreach (Food food in menu)
            {
                if (food.Id == id)
                {
                    food.Name = name;
                    food.Description = description;
                    food.Price = price;
                    food.IsAvailable = isAvailable;
                    return;
                }
            }
            Console.WriteLine("Food not found");
        }

    }

}

/*


bob.wash(water, wash)
 
 
 
 
 */