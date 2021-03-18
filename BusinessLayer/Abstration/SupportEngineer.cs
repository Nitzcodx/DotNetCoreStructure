using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class SupportEngineer : IUtilization, IWeekendUtilization
    {
        public string EngineerName { get; set; }

        public SupportEngineer(string name)
        {
            EngineerName = name;
        }

        public int GetUtilization()
        {
            return 20;
        }

        int IWeekendUtilization.GetUtilizaton()
        {
            return 5000;
        }
    }
}
