using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
                int number1, number2;
                int result1, result2, result3;
            double result4;

            string line; //used for reading

        Console.Write("Please enter the first number:"); //1st number

                line = Console.ReadLine();
                number1 = Convert.ToInt32(line);

            Console.Write("Please enter the second number:"); //2nd number

                line = Console.ReadLine();
                number2 = Convert.ToInt32(line);

            Console.Write("Please choose an operation:"); //Choosing the operator
            char input1 = Convert.ToChar(Console.ReadLine());

            //line = Console.ReadLine();

                result1 = number1 + number2;
                result2 = number1 - number2;
                result3 = number1 * number2;
            //      result4 = number1 / number2;

            if (input1 == '+')
                Console.WriteLine("{0}+{1}={2}", number1, number2, result1);
            else if (input1 == '-')
                Console.WriteLine("{0}-{1}={2}", number1, number2, result2);
            else if (input1 == '*')
                Console.WriteLine("{0}*{1}={2}", number1, number2, result3);
            else if (input1 == '/')
            {
                if (number2 == 0)
                    Console.WriteLine("Error Wrong information inputted");
            }
            else
            {
                result4 = number1 / number2;
                Console.WriteLine("{0}/{1}={2}", number1, number2, result4);
            }
            Console.ReadKey();
            }
    }
}
