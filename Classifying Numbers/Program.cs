using System;

namespace Classifying_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //********************************************************
            // Author: Abdul-Razak, J.
            //
            // Program: Counts zeros, odds, and evens
            // This program counts the number of odd and even numbers.
            // The program also counts the number of zeros.
            //********************************************************
            const int N = 20;
            int counter; //loop control variable
            int number; //variable to store the number read
            int zeros = 0; //variable to store the zero count
            int evens = 0; //variable to store the even count
            int odds = 0; //variable to store the odd count
            Console.WriteLine("Please enter:" + N + " integers ");
            Console.WriteLine("Positive, Negative or Zero ");
            Console.WriteLine("The numbers you entered are: ");
            for (counter = 1; counter <= N; counter++) //Step 3
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.Write(number + " "); //Step 3b
                switch (number % 2)
                {
                    case 0:
                        evens++;
                        if (number == 0)
                            zeros++;
                        break;
                    case 1:
                    case -1:
                        odds++;
                        break;
                } //end switch
                Console.WriteLine("There are " + evens + " even which includes " + zeros + " zeros");
                Console.WriteLine("The number of odd numbers is: " + odds);
            }
        }
    }
}
