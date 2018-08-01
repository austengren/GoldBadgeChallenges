using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
   public class Claim
    {
        //Constructor
        public Claim(int claimID, string claimType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            _isValid = IsValid();
        }

        public override string ToString()
        {
            return $"ClaimID: {ClaimID} \n" +
            $"Claim Type: {ClaimType} \n" +
            $"Description: {Description} \n" +
            $"Claim Amount: {ClaimAmount} \n" +
            $"Date of Incident: {DateOfIncident} \n" +
            $"Date of Claim: {DateOfClaim} \n" +
            $"Is Valid: {_isValid} \n";
        }

        public Claim(DateTime dateOfIncident)
        {
            DateOfIncident = dateOfIncident;
        }

        //Properties
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public TimeSpan TimeBetweenIncidentAndClaim => DateOfClaim - DateOfIncident;

        private bool _isValid;

        public bool IsValid()
        {
            if (TimeBetweenIncidentAndClaim.Days <= 30)
                return true;
            else
                return false;
        }
    }
}
