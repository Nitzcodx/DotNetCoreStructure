using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public abstract class Developer
    {
        public string DeveloperName { get; set; }

        public List<string> TechStack;

        public Developer(string name)
        {
            DeveloperName = name;
            TechStack = new List<string>();
        }

        public abstract void AddTechStack(string[] tech);
    }
}
