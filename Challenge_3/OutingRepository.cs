using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        private List<Outings> _outings = new List<Outings>();

        public void AddOutingToList(Outings item)
        {
            _outings.Add(item);
        }

        public List<Outings> GetList()
        {
            return _outings;
        }

        public double CostPerEvent()
        {
            double sum = 0;
            foreach (Outings outing in _outings)
            {
                sum += outing.CostPerEvent;
            }
            return sum;
        }

        public double EventType(string eventType)
        {
            double sum = 0;
            foreach (Outings outing in _outings)
            {
                if (outing.EventType == eventType)
                {
                    sum += outing.CostPerEvent;
                }
            }
            return sum;
        }

        public int GetCount()
        {
            return _outings.Count;
        }
    }
}
