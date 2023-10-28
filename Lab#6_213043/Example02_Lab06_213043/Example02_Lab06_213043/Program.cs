using System;
using System.Collections.Generic;
namespace AddelementsInList
{
    class program
    {
        static void Main(string[] args)
        {
          
            List<int> ints = new List<int>();
            ints.Add(11);
            ints.Add(22);
            ints.Add(33);

            ints.AddRange(ints);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
