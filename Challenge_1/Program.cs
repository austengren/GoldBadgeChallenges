using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CafeMenu chickenTenders = new CafeMenu("Chicken Tenders", 1, "Crispy delicious chicken tenders.", "Chicken, Breading, Fries, BBQ Sauce", 9.95m);
            CafeMenu bltPanini = new CafeMenu("BLT Panini", 2, "Lightly toasted BLT Panini made with apple wood bacon.", "Apple wood bacon, Tomatoes, lettuce, bread", 7.50m);
            CafeMenu cheeseburger = new CafeMenu("Cheeseburger", 3, "Incredible cheeseburger made with your chose of cheese.", "Ground beef, Cheese, Bread, Ketchup, Mustard", 10.50m);
            CafeMenu salad = new CafeMenu("Salad", 4, "Stay healthy with this salad. Plant Power!", "Greens, Tomatoes, Plant protein, Dressing", 8.95m);
            CafeMenu kidsMacCheese = new CafeMenu("Kids Mac and Cheese", 5, "Every kids favorite meal Mac and Cheese.", "Pasta, cheese", 6.50m);

            MenuRepository _cafeMenu = new MenuRepository();

            _cafeMenu.AddItemToMenu(chickenTenders);
            _cafeMenu.AddItemToMenu(bltPanini);
            _cafeMenu.AddItemToMenu(cheeseburger);
            _cafeMenu.AddItemToMenu(salad);
            _cafeMenu.AddItemToMenu(kidsMacCheese);


            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Komodo Cafe");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) View All Meals");
                Console.WriteLine("2) Add A New Meal");
                Console.WriteLine("3) Delete A Meal");
                Console.WriteLine("4) Exit");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    _cafeMenu.PrintAllMenuItemswithDetails();
                    return true;
                }
                else if (result == "2")
                {
                    _cafeMenu.AddMealByName();
                    return true;
                }
                else if (result == "3")
                {
                    _cafeMenu.RemoveMealByName();
                    return true;
                }
                else if (result == "4")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
