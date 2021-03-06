﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();

        public void AddItemToMenu(CafeMenu item)
        {
            _menuRepo.AddItemToMenu(item);
        }

        public void PrintAllMenuItemswithDetails()
        {
            foreach (var item in _menuRepo.GetList())
            {
                Console.WriteLine($"Meal Name: {item.Name} \n" +
                    $"Meal Number: {item.Number} \n" +
                    $"Description: {item.Description} \n" +
                    $"Ingredients: {item.Ingredients} \n" +
                    $"Price: {item.Price} \n");
            }
            Console.ReadLine();
        }

        public void AddMealByName()
        {
            Console.Clear();

            Console.WriteLine("Name the meal you would like to add:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a number for your meal:");
            string numberAsString = Console.ReadLine();
            int number = Int32.Parse(numberAsString);

            Console.WriteLine("Enter a description for your meal:");
            string description = Console.ReadLine();

            Console.WriteLine("List ingredenits for your meal:");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Enter a price for your meal:");
            string priceAsString = Console.ReadLine();
            decimal price = Decimal.Parse(priceAsString);

            CafeMenu meal = new CafeMenu(name, number, description, ingredients, price);

            Console.WriteLine($"Here are the details for your meal:\r\n" +
                $"Meal Name: {meal.Name} \r\n" +
                $"Meal Number: {meal.Number} \r\n" +
                $"Description: {meal.Description} \r\n" +
                $"Ingredients: {meal.Ingredients} \r\n" +
                $"Price: {meal.Price}");

            _menuRepo.AddMealByName(meal);

            Console.WriteLine("Your Meal has been successfully added!");

            Console.ReadLine();
        }

        public void RemoveMealByName()
        {
            Console.Clear();

            Console.WriteLine("Name the meal you would like to remove: \n");
            var mealName = Console.ReadLine();

            foreach (var cafeMenu in _menuRepo.GetList())
            {
                if (mealName == cafeMenu.Name)
                {
                    _menuRepo.RemoveMealByName(cafeMenu);
                    break;
                }
            }

            PrintAllMenuItemswithDetails();

            Console.WriteLine("Your Meal has been successfully removed!");

            Console.ReadLine();
        }
    }
}
