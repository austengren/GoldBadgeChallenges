using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ProgramUI
    {
        private ClaimRepository _claimRepo = new ClaimRepository();

        public void AddClaimToQueue(Claim item)
        {
            _claimRepo.AddClaimToQueue(item);
        }

        public void DealWithClaim()
        {
            Claim currentClaim = _claimRepo.GetList().Peek();

            Console.WriteLine(currentClaim);

            Console.WriteLine("Do you want to deal with this claim now? Use Captial Y/N:");
            string result = Console.ReadLine();
            if (result == "Y")
            {
                _claimRepo.RemoveClaim();
            }
        }

        public void PrintAllClaimswithDetails()
        {
            foreach (var item in _claimRepo.GetList())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void AddNewClaim()
        {
            Console.Clear();

            Console.WriteLine("Enter the claim ID:");
            string claimIDAsString = Console.ReadLine();
            int claimID = Int32.Parse(claimIDAsString);

            Console.WriteLine("Enter the claim type");
            string claimType = Console.ReadLine();

            Console.WriteLine("Enter a claim description:");
            string description = Console.ReadLine();

            Console.WriteLine("Amount of Damage:");
            string claimAmountAsString = Console.ReadLine();
            decimal claimAmount = Decimal.Parse(claimAmountAsString);

            Console.WriteLine("Date of Accident (MM,DD,YY):");
            string dateOfIncidentAsString = Console.ReadLine();
            DateTime dateOfIncident = DateTime.Parse(dateOfIncidentAsString);

            Console.WriteLine("Date of Claim (MM,DD,YY):");
            string dateOfClaimAsString = Console.ReadLine();
            DateTime dateOfClaim = DateTime.Parse(dateOfClaimAsString);

            Claim newClaim = new Claim(claimID, claimType, description, claimAmount, dateOfIncident, dateOfClaim);

            Console.WriteLine(newClaim.IsValid());

            Console.WriteLine($"Here are the details for your claim:\r\n");
            Console.WriteLine(newClaim);

            _claimRepo.AddClaimToQueue(newClaim);

            Console.WriteLine("Your Claim has been successfully added!");

            Console.ReadLine();
        }
    }
}
