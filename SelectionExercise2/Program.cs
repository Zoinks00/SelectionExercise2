using System;

namespace SelectionExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInputer = " ";
            

            Console.WriteLine("Please enter a school subject and press the enter key.");

            userInputer = Console.ReadLine();
           
        switch (userInputer)

            {//start of switch

                case "science":
                    Console.WriteLine("You like making things go boom dont you.");
                    break;
                case "math":
                    Console.WriteLine("You must be a nerd.");
                    break;
                case "english":
                    Console.WriteLine("I are gud at grammar too.");
                    break;
                case "art":
                    Console.WriteLine("A very relexing subject.");
                    break;
                case "pe":
                    Console.WriteLine("You must watch a lot of sports.");
                    break;
                default:
                    Console.WriteLine("You have not entered a selectable option. Please try again using");
                    Console.Write("science, math, english, art or pe as selectable option.");
                    break;
            }// end of switch
            
        }
    }
}
