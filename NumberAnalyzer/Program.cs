using System;


namespace NumberAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Analyzer!");
            Console.WriteLine();
            Console.WriteLine("Together we can look at numbers! What is your name?");
            var usersName = Console.ReadLine();
            Console.WriteLine();

            bool toContinue = true;

            while (toContinue == true)
            {


                Console.WriteLine("Hi " + usersName + "! Please enter an integer between 1 and 100.");
                var usersNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (usersNumber % 2 != 0 && usersNumber < 60)
                {
                    Console.WriteLine("That number is odd and it is less than 60!");
                }
                else if (usersNumber % 2 == 0 && usersNumber >= 2 && usersNumber <= 24)
                {
                    Console.WriteLine("That number is even and it is less than 25!");
                }
                else if (usersNumber % 2 == 0 && usersNumber >= 26 && usersNumber <= 60)
                {
                    Console.WriteLine("That number is even and it is greater than 60!");
                }
                else if (usersNumber % 2 == 0 && usersNumber > 60)
                {
                    Console.WriteLine("That number is even and greater than 60!");
                }
                else if (usersNumber % 2 != 0 && usersNumber > 60)
                {
                    Console.WriteLine("That number is odd and greater than 60!");
                }


                bool y = true;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Would you like to enter another number? yes/no");
                    var userContinue = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    if (userContinue == "yes")
                    {
                        toContinue = true;
                        y = false;
                    }
                    if (userContinue != "yes" && userContinue != "no")
                    {
                        Console.WriteLine("Hi " + usersName + " please enter either yes or no");
                        y = true;
                    }
                    if (userContinue == "no")
                    {
                        Console.WriteLine("Thank you for playing! Have a great day " + usersName + "!");
                        toContinue = false;
                        break;
                    }
                } while (y == true);
            }

        }

    }
}