﻿using System;
using System.Collections.Generic;

namespace SD230A2BubbleSortaArray
{
    class Program
    {
        //public List<int> Input { get; set; }

        static void Main(string[] args)
        {
    var newInput = new List<int>()
            {
                8, -1, 7, 9, 4, -10, 0, 6, 2
            };


            for (int i = 0; i < newInput.Count; i++)
            {
                if (i > i + 1)
                {
                    Console.WriteLine(i);
                }
            }

     Console.ReadLine();


        }
    }
}
