using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class CountingVallies
    {
        static int countingValleys(int n, string s)
        {
            char[] a = s.ToCharArray();
            var seaLevel = 0;
            var valleys = 0;

            for(int i = 0; i<a.Length; i++)
            {
                var temp = seaLevel; 
                if (a[i].Equals('U'))
                {
                    seaLevel++;
                }
                else
                {
                    seaLevel--;
                }

                if (seaLevel==0 && temp-seaLevel<0)
                {
                    valleys++;
                }
            }

            //valleys--;
            return valleys;
        }

        static void main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
