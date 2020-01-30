//Author Jeremy Maury
//Date: 1/30/20
//Comments: C# iteration statement program

using System;

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts the user to enter a value between 1 and 100
            Console.WriteLine("Please enter an interger between the numbers 1 to 100: ");

            //Try & catch statment to validate the user's input
            try
            {
                //Variable will get a value from the user
                string input = Console.ReadLine();

                //Used to perform the loop and parsed as an interger
                int value = int.Parse(input);

                //Keeps count of how many times the loop runs, and sets it to 1
                int count = 1;

                //
                while (count <= value)
                {
                    //Displays a message with how many times it looped given the user input
                    Console.WriteLine("You have entered " + value.ToString() + ". " + "This is the current interger value in the loop: " + count.ToString());

                    //Increases loop count
                    count++;
                }
            }

            //If the user inputs an invalid value, the catch statement will provide an error
            catch
            {
                //Alerts the user that there was an error
                Console.WriteLine("You have entered an incorrect value");
                Console.WriteLine("Please enter an interger between 1 and 100");
            }
        }
    }
}
