using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Memory:IDisposable
    {
        public Memory()
        {
            Console.WriteLine("Object Created");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);  //Avoid calling destructor for destroying this object
            Console.WriteLine("Object destroyed");
            //destroy objects
        }

        /// <summary>
        /// Destructor called automatically by Garbage Collector
        /// </summary>
        //~Memory()
        //{
        //    Console.WriteLine("Destructor Called");
        //    //Remove not required files and objects
        //}
        //protected override void Finalize()
        //{
        //    try
        //    {
        //        // Cleanup statements... 
        //    }
        //    finally
        //    {
        //        //base.Finalize();
        //    }
        //}

        //to manage desrution properly and not when program executions ends we use Dispose

    }
}
