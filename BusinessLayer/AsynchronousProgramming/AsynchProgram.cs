using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AsynchProgram
    {
        //public static string ReadFile()
        //{
        //    //connect to network
        //    string data = "This is data from server";
        //    Thread.Sleep(5000);
        //    return data;
        //}

        //public static string ReadData()
        //{

        //    string res =ReadFile();
        //    string test = "a" + "b"//some operation waits
        //    return res;

        //}
        public static string ReadFile()
        {
            //connect to network
            string data = "This is data from server";
            Thread.Sleep(10000);    //10 sec
            return data;
        }

        public async static Task<string> ReadData()
        {

            //string res = ReadFile();
            //string res = Task.Run(() => ReadFile());
            Task<string> res = Task.Run(() => ReadFile());
            string test = "a" + "b";    //Some operation completes before ReadFle completes
            string result = await res;  //await waits for the task
            return result;

        }
    }
}
