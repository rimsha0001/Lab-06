using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        static void Main(string[] args)
        {

            List<int> ints = new List<int>() { 10, 20, 30, 40 };
            bool res = ints.TrueForAll(i => i % 2 == 0);
            Console.WriteLine(res);


        }
    }
}