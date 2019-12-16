using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BusinessLayer
{
    public class HealthFacade
    {
        List<Staff> staffList = new List<Staff>();
        List<Client> clientList = new List<Client>();

        public Boolean addStaff(int id, string firstName, string surname, string address1, string address2, StaffCategory category, double baseLocLat, double baseLocLon)
        {            
            var newStaff = new Staff(id, firstName, surname, address1, address2, category, baseLocLat, baseLocLon)
            {
                Id = id,
                FirstName = firstName,
                Surname = surname,
                Address1 = address1,
                Address2 = address2,
                Category = category,
                BaseLocLat = baseLocLat,
                BaseLocLon = baseLocLon
            };
            try
            {
                staffList.Add(newStaff);
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public Boolean addClient(int id, string firstName, string surname, string address1, string address2, double locLat, double locLon)
        {
            /*
             * Add your implementation here!
             */
           
            return false;
        }

        public Boolean addVisit(int[] staff, int patient, int type, string dateTime)
        {
            /*
             * Add your implementation here!
             */
            throw new Exception("Error - add visit not yet implemented (Patient "+ patient +" @" + dateTime+")\n");

            return false;//If no errors thrown, assum OK
        }


        public String getStaffList()
        {
            if (staffList == null)
            {
                return "Staff list not implemented!\n";
            }
            else
            {        
              var result = string.Concat(staffList.Select(s => s.FirstName + " " + s.Surname + " - " + s.Address1 + " - " 
                                                         + s.Address2 + " - " + s.Category + " - " + s.BaseLocLat + " - " + s.BaseLocLon + "\n"));
                return result;
            }
        }

        public String getClientList()
        {
            String result = "Client list not implemented!\n";

            return result;
        }

        public String getVisitList()
        {
            String result = "Visit list not implemented!\n";

            return result;
        }


        public void clear()
        {

        }


        public Boolean load()
        {
            return false;
        }

        public bool save()
        {
            return false;
        }

    }
}
