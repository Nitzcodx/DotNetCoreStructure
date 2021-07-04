using System;
using System.Collections.Generic;
using BusinessLayer;

namespace DotNetCoreStructure
{
    class Program
    {

        //-------------------------------------------------------//
        //    Product <---has a---  Cart
        //       /\
        //      /  \is a
        //     /    \
        //    /      \
        //Software  Hardware
        //-------------------------------------------------------//

        //-------------------------------------------------------//
        //      IUtilization----            ---IWeekendUtilization
        //                      |           |
        //                      |           |
        //                      |           |
        //                      |           |   
        //                      |           |
        //    Developer         |           |
        //       /\             |           |
        //      /  \is a        |           |
        //     /    \           |           |
        //    /      \          |           |
        //Backend  Frontend     |   Support Engineer
        //   |        |         |           |
        //   -------------------------------
        //-------------------------------------------------------//



        static void Main(string[] args)
        {
            Console.WriteLine("Hello .Net Core!");
            MyFirstClass myFirstObject = new MyFirstClass();
            Console.WriteLine($"Value of my first property in .net core = {myFirstObject.MyFirstProperty}");
            int myMethodReturned = myFirstObject.MyFirstMethod(myFirstObject.MyFirstProperty);
            Console.WriteLine($"My method answer = {myMethodReturned}");

            Console.WriteLine("-------------------------------------------------------------");

            EncapsulationClass mySecondObject = new EncapsulationClass();
            mySecondObject[2] = "First Object of Encapsulation Class";

            EncapsulationClass myThirdObject = new EncapsulationClass();
            myThirdObject[2] = "Second Object of Encapsulation Class";

            Console.WriteLine($"Object One:\n {mySecondObject.PrimaryKey} - {mySecondObject.AnotherProperty}");
            Console.WriteLine($"Object Two:\n {myThirdObject.PrimaryKey} - {myThirdObject.AnotherProperty}");
            Console.WriteLine($"Total Objects:  {EncapsulationClass.CountObjects()}");

            Console.WriteLine("-------------------------------------------------------------");

            Product productOne = new Product("My First Product");
            Product productTwo = new Product("My Second Product");
            Product productThree = new Product("My Third Product");

            Cart_HasA_Product_Aggregation_ myFirstCart = new Cart_HasA_Product_Aggregation_(
               new Product[] { productOne, productTwo, productThree }
            );

            myFirstCart.PrintProducts();

            Console.WriteLine("-------------------------------------------------------------");

            Product visualStudio = new SoftwareProduct("Visual Studio v2019");  //Dynamic Polymorphism
            Product adreno = new HardwareProduct("Adreno");
            Console.WriteLine(visualStudio.PrintProduct(visualStudio)); //Dynamic Method Dispatch
            Console.WriteLine(adreno.PrintProduct(adreno));
            Console.WriteLine(productOne.PrintProduct(productOne));

            //Console.WriteLine(adreno.EOL);    visualStudio.LicenseExpiryDate  //Not accessible

            SoftwareProduct SSMS = new SoftwareProduct("SQL Server Mangement Studio v2019");
            //Console.WriteLine(SSMS.LicenseExpiryDate);    //Accessible

            //To solve the issue use TypeCasting
            Console.WriteLine($"Product({visualStudio.ProductName}) expires on: {((SoftwareProduct)visualStudio).LicenseExpiryDate}");


            Console.WriteLine("-------------------------------------------------------------");

            MyAbstractClass abstractObj = new Abstraction();
            abstractObj.NonAbstratMethod();
            Console.WriteLine($"Abstract class propety value is {abstractObj.AbstractClassProperty}");
            Console.WriteLine($"Message from abstract method: {abstractObj.AbstractMethod()}");

            Console.WriteLine("-------------------------------------------------------------");

            Developer nitish = new BackEndDeveloper("Nitish");
            // Can use interface to instantiate : IUtilization nitish = new BackEndDeveloper("Nitish");
            nitish.AddTechStack(new string[] { "C#,SQL Server, Entity Framework", "Web API", "DevOps" });

            Developer nitin = new FrontEndDeveloper("Nitin");
            nitin.AddTechStack(new string[] { "HTML5", "CSS3", "JavaScript", "Bootstrap", "Angular", "Jira" });

            SupportEngineer nikhil = new SupportEngineer("Nikhil");

            Product fullStackApp = new Product("Library Management System");
            fullStackApp.Cost = 300000;

            decimal _nitishCost = fullStackApp.Cost * ((BackEndDeveloper)nitish).GetUtilization() / 100;
            decimal _nitinCost = fullStackApp.Cost * ((FrontEndDeveloper)nitin).GetUtilization() / 100;
            decimal _nikhilCost = fullStackApp.Cost * nikhil.GetUtilization() / 100;

            Console.WriteLine($"Product: {fullStackApp.ProductName} \n" +
                $"Total Cost: {fullStackApp.Cost} \n" +
                $"Development Cost: {_nitishCost + _nitinCost} \n" +
                $"SupportCost: {_nikhilCost}");

            //Explicit interface to differentiate between same method names from different interfaces
            IWeekendUtilization _noopur = new SupportEngineer("Noopur");
            Console.WriteLine($"Updated product cost: {fullStackApp.Cost + _noopur.GetUtilizaton()}");

            Console.WriteLine("-------------------------------------------------------------");

            CarInventory DeltaTraders = new CarInventory();
            Console.WriteLine(DeltaTraders.GetInventory());

            Console.WriteLine("-------------------------------------------------------------");
            EventDate Date = new EventDate();
            Date.AddDate(new DateTime(2004, 02, 12));
            Date.AddDate(DateTime.Today);
            Date.AddDate("23-May-2018");
            Console.WriteLine(Convert.ToString(Date.GetSpecialDate()));

            Console.WriteLine("-------------------------------------------------------------");
            MyCollections collections = new MyCollections();
            collections.AddToArrayList();
            Console.WriteLine($"Items in array list:" + Environment.NewLine +
                $"{collections.GetFromArrayList()}"); ;
            collections.AddToGenericList();
            Console.WriteLine($"tems in generic list<>: " + Environment.NewLine +
                $"{collections.GetFromGenericList()}");
            collections.AddToDictionary();
            Console.WriteLine($"Items in generic dictionary:" + Environment.NewLine +
                $"{collections.GetFromGenericDictionary()}");
            Console.WriteLine($"Keys- " + Environment.NewLine +
                $"{collections.GetKeysFromGenericDictionary()}");
            Console.WriteLine($"Values- " + Environment.NewLine +
                $"{collections.GetValuesFromGenericDictionary()}");
            Console.WriteLine($"Search for Sleepwell:{(collections.SearchInGenericDictionary("Sleepwell") ? "Found" : "NA")} ");
            Console.WriteLine($"Search for Book:{(collections.SearchInGenericDictionary("Pale Blue Dot") ? "Found" : "NA")} ");
            Console.WriteLine();
            collections.AddToGenericSortedList();
            Console.WriteLine($"Items in generic sorted list:" + Environment.NewLine +
                $"{collections.GetAlphanumericSortedFromSortedList()}");

            Console.WriteLine("-------------------------------------------------------------");
            CSharpEnhancements newVariables = new CSharpEnhancements();
            string outVariable = string.Empty;
            Console.WriteLine($"Explicit Variable:{newVariables.VariableTypes(out outVariable)}" + Environment.NewLine +
                $"Implicit Variable:{outVariable}");
            Console.WriteLine();
            Initializers init = new Initializers { };
            Console.WriteLine(init.RunMethods());

            Console.WriteLine("-------------------------------------------------------------");
            PushNotifications notification = new PushNotifications();
            Console.WriteLine($"Single Cast Delegation:" + Environment.NewLine +
                $"{notification.Push()}");
            Console.WriteLine();
            Console.WriteLine($"Message to backend developer using Multi Cast Delegation:" + Environment.NewLine +
                $"{notification.Push(to: nitish)}");
            Console.WriteLine($"Message to frontend developer using Multi Cast Delegation:" + Environment.NewLine +
                $"{notification.Push(to: nitin)}");
            Console.WriteLine($"Anonymous Method Says : {notification.birthdayNotification(nitish.DeveloperName)}");
            Console.WriteLine("-------------------------------------------------------------");
            LambdaExpression lambdaExpression = new LambdaExpression();
            Console.WriteLine($"{lambdaExpression.lambdaExp("Himanshu")}");
            Console.WriteLine(lambdaExpression.getGreeting("Gunjan"));
            lambdaExpression.displayGreeting("Rishi");
            Console.WriteLine($"That's {lambdaExpression.pred("Deepali")}");
            Console.WriteLine("-------------------------------------------------------------");
            int number = 23;
            string testString = "lorem ipsum";
            Console.WriteLine($"Extenion Methods:" + Environment.NewLine +
                $"Factors Count:{number.GetFactorsCount()}" + Environment.NewLine +
                $"IsEven:{number.IsEven()}" + Environment.NewLine +
                $"Pascal Casing:{testString.GetPascalCase()}");
            Console.WriteLine("-------------------------------------------------------------");

            LetsQuery _query = new LetsQuery();
            string immediateRes, deferredRes;
            _query.GetProducts(out deferredRes, out immediateRes);

            Console.WriteLine($"Deferred Execeution Output:" + Environment.NewLine +
                $"{deferredRes}");

            Console.WriteLine($"Immediate Execution Output:" + Environment.NewLine +
                $"{immediateRes}");

            Console.WriteLine($"Filtered Output:" + Environment.NewLine +
                $"{_query.GetRefinedProducts()}");

            Console.WriteLine($"Grouped Products:" + Environment.NewLine +
                $"{_query.GroupByProducts()}");

            Console.WriteLine($"Joined Products:" + Environment.NewLine +
                $"{_query.JoinProducts()}");
            Console.WriteLine("-------------------------------------------------------------");
            FileHandler fileHandle = new FileHandler { Path=Environment.CurrentDirectory+ @"\FileIO.csv" };
            fileHandle.Write(nitish);
            Console.WriteLine($"File Read as follows -" + Environment.NewLine +
                $"{fileHandle.Read()}");
        }
    }
}
