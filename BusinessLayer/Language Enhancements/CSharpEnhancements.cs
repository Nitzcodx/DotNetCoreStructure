using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class CSharpEnhancements
    {
        public dynamic dynamicProp { get; set; }

        public dynamic VariableTypes(out string myVar)
        {
            var myFirstVar = "Hi implicit variable";
            myVar = myFirstVar;
            //myFirstVar = 8;
            dynamic mydynamicVar;
            mydynamicVar = 78;
            mydynamicVar = "Hi dynamic variable";

            return mydynamicVar;
            #region Difference in var and dynamic
                //1. Statically typed  vs dynamically typed
                //2. Mandatory initilization in var
                //3. Once assigned type cannot be changed in var
                //4. Cannot pass as a method argument in var
                //5. Cannot create member variable in var
                //6. Cannot be assignes to null in var
            #endregion

        }
    }
}
