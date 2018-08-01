using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI _claimUI = new ProgramUI();

            DateTime date1 = new DateTime(2018,4,25);
            DateTime date2 = new DateTime(2018,4,27);
            DateTime date3 = new DateTime(2018,4,26);
            DateTime date4 = new DateTime(2018,4,28);
            DateTime date5 = new DateTime(2018,4,27);
            DateTime date6 = new DateTime(2018,6,1);

            Claim claim1 = new Claim(1, "Car", "Car accident on 465.", 400.00m, date1, date2);
            Claim claim2 = new Claim(2, "House", "House fire in kitchen.", 4000.00m, date3, date4);
            Claim claim3 = new Claim(3, "Theft", "Stolen pancakes.", 4.00m, date5, date6);

            _claimUI.AddClaimToQueue(claim1);
            _claimUI.AddClaimToQueue(claim2);
            _claimUI.AddClaimToQueue(claim3);

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            
            bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Komodo Claims Department");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) View All Claims");
                Console.WriteLine("2) Deal With Claim");
                Console.WriteLine("3) Add New Claim");
                Console.WriteLine("4) Exit");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    _claimUI.PrintAllClaimswithDetails();
                    return true;
                }
                else if (result == "2")
                {
                    _claimUI.DealWithClaim();
                    return true;
                }
                else if (result == "3")
                {
                    _claimUI.AddNewClaim();
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