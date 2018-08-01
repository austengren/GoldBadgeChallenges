using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        private OutingRepository _outingRepo = new OutingRepository();

        public void AddOutingToList(Outings item)
        {
            _outingRepo.AddOutingToList(item);
        }

        public void PrintAllOutingssWithDetails()
        {
            Console.Clear();

            foreach (var item in _outingRepo.GetList())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void CostPerEvent()
        {
            Console.Clear();

            Console.WriteLine("The total from all outings is: " + _outingRepo.CostPerEvent());
            Console.ReadLine();
        }

        public void EventType()
        {
            Console.Clear();

            Console.WriteLine("Enter Event Type (Golf, Bowling, Amusement Park, Concert):");
            string eventType = Console.ReadLine();

            _outingRepo.EventType(eventType);

            Console.WriteLine("Here is the total for" + " " + eventType + ":" + " " + _outingRepo.EventType(eventType));
            Console.ReadLine();
        }

        public void AddNewOuting()
        {
            Console.Clear();

            Console.WriteLine("Enter Event Type (Golf, Bowling, Amusement Park, Concert):");
            string eventType = Console.ReadLine();

            Console.WriteLine("Enter number of people who attended:");
            string peopleAttendedAsString = Console.ReadLine();
            int peopleAttended = Int32.Parse(peopleAttendedAsString);

            Console.WriteLine("Total cost for event:");
            string costPerEventAsString = Console.ReadLine();
            double costPerEvent = Double.Parse(costPerEventAsString);

            Console.WriteLine("Date of Event (MM,DD,YY):");
            string dateAsString = Console.ReadLine();
            DateTime date = DateTime.Parse(dateAsString);

            Outings newOuting = new Outings(eventType, peopleAttended, date, costPerEvent);

            Console.WriteLine($"Here are the details for your outing:\r\n");
            Console.WriteLine(newOuting);

            _outingRepo.AddOutingToList(newOuting);

            Console.WriteLine("Your Outing has been successfully added!");

            Console.ReadLine();
        }
    }
}
