using System;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var age = 32;

            //string firstName;

            //firstName = Console.ReadLine();
            //Console.Beep();
            //Console.WriteLine("Hello " + firstName);

            //if(firstName == "Mat")
            //{
            //    Console.WriteLine("Go away...");
            //}
            //else
            //{
            //    Console.WriteLine
            //}
            //Console.WriteLine($"You are {age} years old");

            //Console.WriteLine("CALCULATOR");
            //Console.WriteLine("First number to add");
            //var first = Console.ReadLine();

            //double firstNum = Convert.ToDouble(first);

            //Console.WriteLine("Second number to add");
            //var second = Console.ReadLine();

            //double secondNum = Convert.ToDouble(second);

            //var result = firstNum + secondNum;
            //Console.WriteLine(result);

            //Homework Calculator
            Console.WriteLine("HomeWork Calculator");

            Console.WriteLine("(A)dd");
            Console.WriteLine("(S)ubstract");
            Console.WriteLine("(D)evide");
            Console.WriteLine("(M)ultiply");
            Console.WriteLine("What You want to do?");
            string operation = Console.ReadLine().ToUpper();

            Console.WriteLine("Type in first number");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type in second number");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            double result;

            switch (operation)
            {
                case "A":
                    result = firstNumber + secondNumber;
                    break;
                case "S":
                    result = firstNumber - secondNumber;
                    break;
                case "D":
                    result = firstNumber / secondNumber;
                    break;
                case "M":
                    result = firstNumber * secondNumber;
                    break;
                default:
                    result = 0;
                    Console.WriteLine("Operation is unknown.");
                    break;
            }
            
            Console.WriteLine($"Result: { result }");


        }
    }
}
