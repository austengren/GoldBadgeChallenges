using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        private Queue<Claim> _claim = new Queue<Claim>();

        public void AddClaimToQueue(Claim item)
        {
            _claim.Enqueue(item);
        }

        public Queue<Claim> GetList()
        {
            return _claim;
        }

        public void RemoveClaim()
        {
            _claim.Dequeue();
        }

        public int GetCount()
        {
            return _claim.Count;
        }
    }
}
