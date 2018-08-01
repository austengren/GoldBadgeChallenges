using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI _outingUI = new ProgramUI();

            DateTime date1 = new DateTime(2018, 4, 25);
            DateTime date2 = new DateTime(2018, 5, 25);
            DateTime date3 = new DateTime(2018, 6, 25);
            DateTime date4 = new DateTime(2018, 7, 25);

            Outings outing1 = new Outings("Golf", 4, date1, 100.00);
            Outings outing2 = new Outings("Bowling", 4, date2, 80.00);
            Outings outing3 = new Outings("Amusement Park", 4, date3, 200.00);
            Outings outing4 = new Outings("Concert", 4, date4, 400.00);

            _outingUI.AddOutingToList(outing1);
            _outingUI.AddOutingToList(outing2);
            _outingUI.AddOutingToList(outing3);
            _outingUI.AddOutingToList(outing4);

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Komodo Outings Manager");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) View All Outings");
                Console.WriteLine("2) Add New Outing");
                Console.WriteLine("3) View Total Cost");
                Console.WriteLine("4) View Cost by Event Type");
                Console.WriteLine("5) Exit");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    _outingUI.PrintAllOutingssWithDetails();
                    return true;
                }
                else if (result == "2")
                {
                    _outingUI.AddNewOuting();
                    return true;
                }
                else if (result == "3")
                {
                    _outingUI.CostPerEvent();
                    return true;
                }
                else if (result == "4")
                {
                    _outingUI.EventType();
                    return true;
                }
                else if (result == "5")
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
