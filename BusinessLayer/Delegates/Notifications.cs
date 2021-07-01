using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public delegate string NotifyDelegate(string devname);      //1) Declare same as method return and argument type and seq
    public class Notifications
    {
        public NotifyDelegate Notify { get; set; }  //2) delegate property to hold function references
        public string SendToFrontEndDeveloper(string devname)
        {
            return $"Hi {devname}, a new training on Angular is available. Please complete.";
        }
        public string SendToBackEndDeveloper(string devname)
        {
            return $"Hi {devname}, a new training on DBMS is available. Please complete.";
        }

    }

}
