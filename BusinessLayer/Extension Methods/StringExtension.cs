using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    //cannot override string class to implement own functioanlity because it's a sealed class
    public static class StringExtension
    {
        public static string GetPascalCase(this string name)
        {
            List<string> words = name.Split(' ').ToList();
            string pascal = string.Empty;
            foreach(string word in words)
            {
                pascal += word[0].ToString().ToUpper() + word.Substring(1) + " ";
            }
            return pascal;
        }
    }
}
