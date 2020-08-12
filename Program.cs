using System;

namespace VirtualTill
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the TMS Till Management System."); //I'm tempted to make this gui eventually..?  surely winforms...
                                                                             //Might not be too hard.
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();

            Menu menu = new Menu(); //handler.

            while (true) //infinite loop for the program. is this the best way though?
            {
                int option;
                Console.WriteLine("---------------------");
                Console.Clear();
                Console.WriteLine("Enter an option.");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 99:

                        break;
                }

            }
        }
    }
}