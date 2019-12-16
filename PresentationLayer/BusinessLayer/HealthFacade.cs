using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{

    public static class visitTypes
    {
        public const int assessment = 0;
        public const int medication = 1;
        public const int bath = 2;
        public const int meal = 3;
    }
    public class HealthFacade
    {
       


        public Boolean addStaff(int id, string firstName, string surname, string address1, string address2, string category, double baseLocLat, double baseLocLon)
        {
            /*
             * Add your implementation here!
             */ 

   
            return false;
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
            String result = "Staff list not implemented!\n";

            return result;
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
