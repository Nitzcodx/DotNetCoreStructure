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
            nitish.AddTechStack(new string[]{"C#,SQL Server, Entity Framework","Web API", "DevOps"} );

            Developer nitin = new FrontEndDeveloper("Nitin");
            nitin.AddTechStack(new string[] { "HTML5", "CSS3", "JavaScript", "Bootstrap", "Angular", "Zira" });

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



        }
    }
}
