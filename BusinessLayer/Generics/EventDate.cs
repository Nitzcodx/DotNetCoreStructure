using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class EventDate
    {
        public object[] dates;
        private int counter; 

        public EventDate()
        {
            dates = new object[100];
            counter = 0;
        }

        public void AddDate<T>(T date)  //generic method
        {
            dates[counter++] = date;
        }

        public object GetSpecialDate()
        {
            int winnerIndex = (new Random()).Next(0,counter);
            return dates[winnerIndex];
        }

    }
}
