using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        static void Main(string[] args)
        {

            List<int> intList = new List<int>() { 10, 20, 30 };
            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);

        }
    }
}