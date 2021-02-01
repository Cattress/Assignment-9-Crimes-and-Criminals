using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Crime
    {
        private string Act;
        private string Location;
        private DateTime Date;

        public Crime(DateTime date, string location, string act)
        {
            this.Date = date;
            this.Location = location;
            this.Act = act;
        }

        public string GetLocation()
        {
            return Location;

        }

        public string GetAct()
        {
            return Act;
        }

        public DateTime GetDate()
        {
            return Date;
        }


    }
}
