using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Outings
    {
        //Constructor
        public Outings(string eventType, int peopleAttended, DateTime eventDate, double costPerEvent)
        {
            EventType = eventType;
            PeopleAttended = peopleAttended;
            EventDate = eventDate;
            CostPerEvent = costPerEvent;
        }

        public override string ToString()
        {
            return $"Event Type: {EventType} \n" +
            $"People Attended: {PeopleAttended} \n" +
            $"Event Date: {EventDate} \n" +
            $"Cost Per Person: {CostPerPerson} \n" +
            $"Cost Per Event: {CostPerEvent} \n";
        }

        //Properties
        public string EventType { get; set; }
        public int PeopleAttended { get; set; }
        public DateTime EventDate { get; set; }
        public double CostPerPerson => CostPerEvent / PeopleAttended;
        public double CostPerEvent { get; set; }
    }
}
