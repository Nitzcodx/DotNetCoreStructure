using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class PushNotifications
    {
        Notifications obj = new Notifications();
        string message = string.Empty;
        public string Push()
        {
            NotifyDelegate notification = new NotifyDelegate(obj.SendToFrontEndDeveloper);  //Single Cast Delegate
            obj.Notify = notification;
            return notification("Aditya");
        }
        public string Push(Developer to)
        {
            NotifyDelegate notification = new NotifyDelegate(obj.SendToFrontEndDeveloper);
            notification += obj.SendToBackEndDeveloper; //Multi Cast Delegate
            obj.Notify = notification;

            string message = string.Empty;
            foreach(NotifyDelegate item in obj.Notify.GetInvocationList())  //Cannot use var in this loop
            {
                if (item.Method.Name.Equals("SendToFrontEndDeveloper"))
                {
                    if(to is FrontEndDeveloper)
                        message += item(to.DeveloperName) + Environment.NewLine;
                }
                if (item.Method.Name.Equals("SendToBackEndDeveloper"))
                {
                    if (to is BackEndDeveloper)
                        message += item(to.DeveloperName) + Environment.NewLine;
                }
            }
            return message;
        }

        //Used when methods are called less number of times
        public NotifyDelegate birthdayNotification = delegate (string devName)
        {
            return $"Happy birtday {devName}";
        };
    }
}
