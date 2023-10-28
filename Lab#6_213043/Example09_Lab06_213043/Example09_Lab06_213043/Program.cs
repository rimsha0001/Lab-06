using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        static void Main(string[] args)
        {

            List<int> intList = new List<int>() { 10, 20, 30 };
            intList.Insert(1,11);
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }

        }
    }
}
