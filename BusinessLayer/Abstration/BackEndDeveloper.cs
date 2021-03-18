using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BackEndDeveloper : Developer,IUtilization
    {
        public BackEndDeveloper(string name):base(name)
        {

        }
        public override void AddTechStack(string[] tech)
        {
            foreach (string technology in tech) this.TechStack.Add(technology);
        }

        public int GetUtilization()
        {
            return 40;
        }
    }
}
