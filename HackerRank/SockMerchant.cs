using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class SockMerchant
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        var colors = new HashSet<int>();
        var temp = 0;
        var pairs = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            temp = ar[i];
            if (!colors.Contains(temp))
            {
                colors.Add(temp);
            }
            else
            {
                pairs++;
                colors.Remove(temp);
            }

        }

        return pairs;
    }

    static void main(string[] args)
    {
        

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

        var result = sockMerchant(n, ar);
        Console.WriteLine(result);
        Console.ReadLine();

    }
}
