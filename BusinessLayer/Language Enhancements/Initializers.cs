using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Initializers
    {
        public string RunMethods()
        {
            //No constructor required to declare object
            CSharpEnhancements ObjectInitializer = new CSharpEnhancements
            {
                dynamicProp = 23.23
            };

            CSharpEnhancements obj1 = new CSharpEnhancements
            {
                dynamicProp = "Hey Man!"
            };

            CSharpEnhancements obj2 = new CSharpEnhancements
            {
                dynamicProp = true
            };

            //List Initializer
            List<CSharpEnhancements> ListInitializer = new List<CSharpEnhancements>
            {
                ObjectInitializer,
                obj1,
                obj2
            };

            //Anonymous Types - read only
            Product game = new Product("Chess");
            CSharpEnhancements obj3 = new CSharpEnhancements { };   //very cool han?
            var AnonymousType = new
            {
                game.Cost,
                obj2.dynamicProp,
                obj3
            };

            
            return $"Dynamic Property assigned from object initilizer :{ObjectInitializer.dynamicProp}" + Environment.NewLine +
                $"Count of objects in list initializer: {ListInitializer.Count}" + Environment.NewLine +
                $"Anonymous Types: " + Environment.NewLine +
                $"1){AnonymousType.Cost}" + Environment.NewLine +
                $"2){AnonymousType.dynamicProp}" + Environment.NewLine +
                $"3){AnonymousType.obj3}";
        }
    }
}
