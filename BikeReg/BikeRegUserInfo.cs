using System;

namespace BikeReg
{
    public class BikeRegUserInfo
    {
        public string __type { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string Team { get; set; }
        public int? Age { get; set; } /* Seems to be unused */
        public int AgeAtYearEnd { get; set; }
        public int AgeOnEventDate { get; set; }
        public DateTime? DOB { get; set; }
        public int? DOBdd { get; set; }
        public int? DOBmm { get; set; }
        public int? DOByyyy { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string Gender { get; set; }
        public string USACLicense { get; set; }
    }
}
