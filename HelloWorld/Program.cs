﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0 ; i< args.Length; i++)
            {
                Console.WriteLine("Hello {0}", args[i]);

                Console.ReadLine();
            }
        }
    }
}
