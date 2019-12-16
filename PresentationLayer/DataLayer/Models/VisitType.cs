using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public enum FlagType
    {
        assessment = 0,
        medication = 1,
        bath = 2,
        meal = 3
    }
    public class VisitType
    {
        public int Id { get; set; }
        public FlagType Flag { get; set; }
        public string Duration { get; set; }

        //Navigation property
        public List<Staff> RequiredStaffList { get; set; }
    }
}
