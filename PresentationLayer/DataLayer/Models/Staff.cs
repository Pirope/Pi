using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public enum StaffCategory
    {
        General_Practitioner = 0,
        Community_Nurse = 1,
        Social_Worker = 2,
        Care_Worker = 3
    }

    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public StaffCategory Category { get; set; }
        public double BaseLocLat { get; set; }
        public double BaseLocLon { get; set; }

        public Staff(int id, string firstName, string surname, string address1, string address2, StaffCategory category, double baseLocLat, double baseLocLon)
        {
            Id = id;
            FirstName = firstName;
            Surname = surname;
            Address1 = address1;
            Address2 = address2;
            Category = category;
            BaseLocLat = baseLocLat;
            BaseLocLon = baseLocLon;
        }

        //Navigation property
        public List<Visit> Visits { get; set; }
    }
}
