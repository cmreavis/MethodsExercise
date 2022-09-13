using System;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string operationType;
            int result = 0;

            //User input for first and second numbers of basic equation
            Console.WriteLine("Input first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //User input for type of operation
            Console.WriteLine("Input operation symbol:");
            operationType = Console.ReadLine();

            if (operationType == "*")
            {
                result = Methods.Multiply(num1, num2);
                Console.WriteLine(result);
            }
            else if (operationType == "/")
            {
                result = Methods.Divide(num1, num2);
                Console.WriteLine(result);
            }
            else if (operationType == "+")
            {
                result = Methods.Add(num1, num2);
                Console.WriteLine(result);
            }
            else if (operationType == "-")
            {
                result = Methods.Subtract(num1, num2);
                Console.WriteLine(result);
            }
            else
            { Console.WriteLine("Invalid"); }

            

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        
    }
}
