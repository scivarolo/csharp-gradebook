using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Sebastian's Gradebook");

            // prompt user to enter grades and loop until they type 'q' to stop

            while(true)
            {
                Console.WriteLine("Enter a Grade, or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
            }


            //book.AddGrade(89.1);
            //book.AddGrade(90.5);
            //book.AddGrade(77.5);
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }
    }
}
