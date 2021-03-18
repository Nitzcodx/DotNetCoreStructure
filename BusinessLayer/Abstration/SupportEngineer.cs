using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class SupportEngineer : IUtilization
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
    }
}
