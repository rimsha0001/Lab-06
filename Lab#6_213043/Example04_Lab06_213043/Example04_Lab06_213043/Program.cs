using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        static void Main(string[] args)
        {

            List<int> ints = new List<int>() { 10, 20, 30 };
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }
    }
}