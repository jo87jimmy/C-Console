using System;
using System.Collections.Generic;
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int,string> dict = new Dictionary<int, string>();

           dict.Add(0,"Jeff");
           dict.Add(1,"Jimmy");
           dict.Add(2,"Terry");

           Console.WriteLine(dict[0]);
           Console.WriteLine(dict[0][2]);
           Console.WriteLine(dict.Count);
        }
    }
}
