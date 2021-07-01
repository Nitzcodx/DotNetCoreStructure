using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class LambdaExpression
    {
        Notifications obj;
        public LambdaExpression()
        {
            obj = new Notifications();
        }
        /// <summary>
        /// 1)Anonymous Method
        /// </summary>
        //public NotifyDelegate lambdaExp = delegate (string devName)
        //{
        //    return $"Hi {devName} from lamda call";
        //};

        /// <summary>
        /// 2)Introduce => and remove delegate keyword
        /// </summary>
        //public NotifyDelegate lambdaExp = (string devName) =>
        //{
        //    return $"Hi {devName} from lamda call";
        //};

        /// <summary>
        /// 3)Remove input type as it's already defined in delegate
        /// </summary>
        //public NotifyDelegate lambdaExp = (devName) =>
        //{
        //    return $"Hi {devName} from lamda call";
        //};

        /// <summary>
        /// 4)Only one param, remove parethesis and make it one liner
        /// </summary>
        //public NotifyDelegate lambdaExp = devName => {  return $"Hi {devName} from lamda call"; };

        //public NotifyDelegate lambdaExp = () => { return $"Hi {devName} from lamda call"; }; - No param
        //public NotifyDelegate lambdaExp = (x,y) => { return $"Hi {devName} from lamda call"; }; - More than one param

        #region Statement Lambda vs Expression Lambda
        // Statement Lambda has a block of statements within {}
        // Ex. (x,y) => { return x*y ;};
        //Expression Lambda has only an expression and no braces and even no return statement
        // Ex. (x,y) => x*y;
        #endregion

        /// <summary>
        /// 5)Remove return and {}
        /// </summary>
        public NotifyDelegate lambdaExp = devName =>  $"Hi {devName} from lamda call";

        /// <summary>
        /// 6) Calls method only if the method is static
        /// </summary>
        //public NotifyDelegate lambdaCallsMethod = devName => obj.SendToBackEndDeveloper(devName);

        /// <summary>
        /// 6)Remove dependency declaring Delegate, use Func<>
        /// </summary>
        public Func<string, string> getGreeting = x => $"Hello {x} from Func<>";

        //For no return type use Action
        public Action<string> displayGreeting = x =>
        {
            Console.WriteLine($"Hi {x} from Action");
        };


        //Accepts only one param and always returns bool
        public Predicate<string> pred = x => x.Length != 0;
    }
}
