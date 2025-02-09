﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE12
    {
        static void Main()
        {
            int num;

            Console.Write("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Part A: "num num num num" using Write
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            // Part B: "numnumnumnum" using Write
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            // Part C: "num num num num" using {0}
            Console.WriteLine("{0} {0} {0} {0}", num);

            // Part D: "numnumnumnum" using {0}
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
    }
}
