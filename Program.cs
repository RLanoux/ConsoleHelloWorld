using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main( )
        {
            // Declare variables.
            String strUserResponse = String.Empty;
            String strUserName = String.Empty;
            Int32 intFirstNumber = 0;
            Int32 intSecondNumber = 0;
            Int32 intSum = 0;

            //Greet the world.
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            

            //Ask the user for his/her name.
            Console.Write("Enter your name, please. ");
            
            //Get the user's input and store it in variable strUserResponse
            strUserResponse = Console.ReadLine();
            strUserName = strUserResponse;
            /* strUserName and strUserResponse are assignment statements because of the equal, you do what's on the right and store it on the left */

            //Greet user by name.
            Console.WriteLine();
            Console.WriteLine("Hello " + strUserResponse + "! I'll add two numbers for you.");
            /*When you use the + signs it's called concatination, you glue the strings end to end. */

            //A random pause here.
            Pause("Press enter to input your two values.");
            
            //Get the first number and convert it to an actual number.
            Console.Write("Enter your first number: ");
            strUserResponse = Console.ReadLine();

            //Here is where we convert it to an actual number..
            intFirstNumber = Convert.ToInt32(strUserResponse);

            //Get the second number and convert it to an actual number.
            Console.Write("\nEnter your second number: ");
            strUserResponse = Console.ReadLine();

            //Here is where we convert the second number from string to integer (whole number).
            intSecondNumber = Convert.ToInt32(strUserResponse);

            //Add the two numbers and store them in the third integer variable IntSum.
            intSum = AddThem(intFirstNumber, intSecondNumber);

            //Show the user the sum of the integers.
            Console.WriteLine("\nYour sum is " + intSum.ToString() + ".");

            //To show a second AddThem call.
            Console.WriteLine("\nThe sum of 3 and 7 = " + AddThem(3, 7).ToString());

            //Pause code.
            Pause("Press the enter key to close this window.");
            
        }

        static void Pause(String sMsg)
        {
            //Pause code.
            Console.WriteLine();
            Console.WriteLine(sMsg);
            Console.ReadLine();
        }
        
        static Int32 AddThem (Int32 intA, Int32 intSecondNumber)
        {
        Int32 iSum = intA + intSecondNumber;
        return iSum;
        }
    }

}