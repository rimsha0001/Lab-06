using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        static void print(IList<string> list)
        {
            //Console.WriteLine(list.Count);
            foreach (string item in list) 
            { 
                Console.WriteLine(item);            
            }

        }
        static void Main(string[] args)
        {

            string[] strArray = new string[2];
            strArray[0] = "hello";
            strArray[1] = "hi";
            print(strArray);

            List<string> list = new List<string>(); 
            list.Add ("hello");
            list.Add ("hi");
            print(list);


        }
    }
}