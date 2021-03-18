using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class FrontEndDeveloper : Developer,IUtilization
    {
        public FrontEndDeveloper(string name):base(name)
        {

        }
        public override void AddTechStack(string[] tech)
        {
            foreach (string technology in tech) TechStack.Add(technology);
        }

        public int GetUtilization()
        {
            return 40;
        }
    }
}
