﻿using System;

namespace FruitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fruit = new string[5];
            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };


            //Console.WriteLine(fruit[0]);
            //Console.WriteLine(fruit[1]);
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);
            Console.WriteLine($"Today you will have {fruit[userNumber]}.");
        }
    }
}
