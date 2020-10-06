//Author: Elliot Vasquez
// ISM 4200 Assignment #2B
//Comments: This C# console application demonstrates the execution of a conditional statement
//           after a user has input the a numeric grade of their desire. That numeric grade will translate
//              a letter grade.

using System;

namespace ConditionalStatementsEMV
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line of code will prompt the user to input a number value for the grade they expect to receive.
            Console.WriteLine("Hello! What grade do you expect to receive in ISM 4300? Please input a number.");
            
            //This line of code will read the number grade the user has input.
            string number = Console.ReadLine();

            //This line of code parses the number input by the user and assigns it to variable 'grade'.
            decimal grade = decimal.Parse(number);

            if (grade >= 90)
            {
                Console.WriteLine("You shall receive an A!");
            }

            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("You shall receive a B!");
            }

            else if (grade >=70 && grade < 80)
            {
                Console.WriteLine("You shall receive a C!");
            }

            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("You shall receive a D!");
            }

            else if (grade >= 50 && grade < 60)
            {
                Console.WriteLine("You shall receive an F!");
            }
        }
    }
}
