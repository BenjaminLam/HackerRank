using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class CloudJumps
    {
        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c, int n)
        {
            var count = -1;
            for(int i = 0; i < c.Length; i++, count++)
            {
                if (i<n-2 && c[i + 2] == 0)
                {
                    i++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c,n);

           Console.WriteLine(result);
           Console.ReadLine();
        }
    }
}
