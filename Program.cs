/*
 Author: Katera Jefferson
Date: 9/17/2020
*/

using System;
using System.Linq.Expressions;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
            if (value_of_input >= 90) Console.WriteLine("Grade A");
            else if ((value_of_input >= 70) && (value_of_input < 90)) Console.WriteLine("Grade B");
            else if ((value_of_input >= 50) && (value_of_input < 70)) Console.WriteLine("Grade C");
            else if (value_of_input < 50) Console.WriteLine("Grade F");
            else Console.WriteLine("Invalid input");
            }
            catch
            {
            }
        }
    }
}
