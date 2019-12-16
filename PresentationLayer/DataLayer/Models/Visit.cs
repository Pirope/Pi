using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public VisitType Type { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }

        //Navigation property
        public Client Client { get; set; }
    }
}
