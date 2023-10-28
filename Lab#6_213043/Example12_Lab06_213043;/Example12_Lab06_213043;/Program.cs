using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        //private static bool isPositiveInt;

        static bool IsPositiveInt(int value)
        {
            return value > 0;
        }
        static void Main(string[] args)
        {
            
            List<int> ints = new List<int>() { 10, 20, 30, 40 };
            //bool res = ints.TrueForAll(i => i%2 == 0);
            bool res = ints.TrueForAll(IsPositiveInt);
            //Console.WriteLine(res);


        }
        

    }

}
