﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Count number of occurrences of a number in an array [1,2,3,1,3,4,5]

namespace Arraydemo
{
    internal class OccuranceArray
    {

        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 1, 3, 4, 5 };
            
            for(int i=0;i<number.Length;i++)
            {
                for(int j=i+1;j<number.Length;j++)
                {
                    if (number[i] == number[j])
                    {
                        Console.WriteLine(number[i]);
                    }
                }

            }
            
            


        }
    }
}
