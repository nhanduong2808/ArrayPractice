﻿using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is Nhan Duong");
            int[] myArray = { 1, 2, 3, 4, 5 };
            for (int i=0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
