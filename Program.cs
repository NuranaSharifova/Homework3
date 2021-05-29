using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day7.WorlOfTanks;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {

            Tank[] T1 = new Tank[5] {
                new Tank("T-34"),
                new Tank("T-34"),
                new Tank("T-34"),
               new Tank("T-34"),
                new Tank("T-34")
            };
            Tank[] T2 = new Tank[5] {
                new Tank("Pantera"),
                new Tank("Pantera"),
                new Tank("Pantera"),
               new Tank("Pantera"),
                new Tank("Pantera")
            };
            string result;
            for (int i = 0; i < T1.Length; i++)
            {
                result = T1[i] * T2[i];
                Console.WriteLine(result);
            }
        }
    }
}
