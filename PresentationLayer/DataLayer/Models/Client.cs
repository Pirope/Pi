using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public double LocLat { get; set; }
        public double LocLon { get; set; }

        //Navigation property
        public List<Visit> Visits { get; set; }

        public Client(int id, string firstName, string surname, string address1, string address2, double locLat, double locLon)
        {
            Id = id;
            FirstName = firstName;
            Surname = surname;
            Address1 = address1;
            Address2 = address2;
            LocLat = locLat;
            LocLon = locLon;
        }
    }
}
