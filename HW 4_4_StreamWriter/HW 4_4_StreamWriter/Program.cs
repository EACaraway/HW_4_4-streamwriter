using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_4_StreamWriter
{ // Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
    class Program
    {
        static void Main(string[] args)
        {
            // Don't forget to add "using System.IO;" initializing new instance of streamwriter class and creating varialbe "output"
            StreamWriter output = new StreamWriter("output.txt");
            // initialize counters.
            int i = 0;
            int count = 0;

            // ask 20 questions.
            while (i < 20)
            {
                // randomly generate 2 int between 1-15 called "a" and "b" and 1 int called "operation" between 1-4.
                var rand = new Random();
                var a = rand.Next(1, 16);
                var b = rand.Next(1, 16);
                var operation = rand.Next(1, 5);

                // variable to hold corrct answer.
                int answer = 0;

                // Give the user different expressions based on the random value of "operation" 
                switch (operation)
                {
                    case 1:
                        Console.Write($"Enter the result of {a} + {b}: ");
                        // write above line to "output.txt" file.
                        output.Write($"Enter the result of {a} + {b}: ");
                        // store correct answer to "answer"
                        answer = a + b;
                        break;
                    case 2:
                        Console.Write($"Enter the result of {a} * {b}: ");
                        output.Write($"Enter the result of {a} * {b}: ");
                        answer = a * b;
                        break;
                    case 3:
                        Console.Write($"Enter the result of {a} - {b}: ");
                        output.Write($"Enter the result of {a} - {b}: ");
                        answer = a - b;
                        break;
                    case 4:
                        Console.Write($"Enter the result of {a} / {b}: ");
                        output.Write($"Enter the result of {a} / {b}: ");
                        answer = a / b;
                        break;
                }
                // convert user input to int and store in variable "userInput" 
                int.TryParse(Console.ReadLine(), out int userInput);
                output.WriteLine(userInput);

                // compare value in "userInput to value in "answer"
                if (userInput == answer)
                {
                    Console.WriteLine("Congratulations!!! That is correct.");
                    output.WriteLine("Congratulations!!! That is correct.");
                    count++;
                }
                else
                {
                    Console.WriteLine("Sorry, That is not correct.");
                    output.WriteLine("Sorry, That is not correct.");
                }
                i++;
            }

            Console.Clear();
            Console.WriteLine($"You answered {count} question(s) correctly.");
            output.WriteLine($"You answered {count} question(s) correctly.");
            output.Close();
        }
    }
}
