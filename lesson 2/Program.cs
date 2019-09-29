using System;

namespace lesson_2
{
    class Program
    {
        static void WelcomeUser()
        {
            Console.WriteLine("What`s your name");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
        }

        static int RequestNumber(string numberName)
        {
            Console.WriteLine($"What number do you want to use as {numberName} ");

            int exponentBase = int.Parse(Console.ReadLine());

            return exponentBase;
        }

        static int Exponent (int exponentBase, int exponent)
        {
            int result = 1;
            for(int i = 0; i < exponent; i++)
            {
                result = exponentBase * result;
            }

            return result;
        }
        static int RequestExponentBase()
        {
            Console.WriteLine("What number do you want exponentate");

            int exponentBase = int.Parse(Console.ReadLine());

            return exponentBase;
        }

        static int exponentOf2(int number)
        {
            return number * number;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine($"Result: {result} ");
        }

        static bool DecideOnRunningProgramAgain()
        {
            Console.WriteLine("Try Again? Y/N");
            var userResult = Console.ReadLine();

            if (userResult == "Y" || userResult == "y")
            {
                return true;
            } else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            bool runProgramAgain;

            do
            {
                WelcomeUser();
                int exponentBase = RequestExponentBase();
                int result = exponentOf2(exponentBase);
                PrintResult(result);
                runProgramAgain = DecideOnRunningProgramAgain();

            } while (runProgramAgain);

            //while(runProgramAgain)
            //{
            //    WelcomeUser();
            //    int exponentBase = RequestExponentBase();
            //    int result = exponentOf2(exponentBase);
            //    PrintResult(result);
            //    runProgramAgain = DecideOnRunningProgramAgain();
            //}

            Console.WriteLine("Bye bye");
            Console.ReadLine();
            

            
        }
    }
}
;