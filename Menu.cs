using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualTill
{
    class Menu
    {
        private List<Till> tills = new List<Till>(); //the menu handles all till management.
        public void addTill()
        {
            string newName;
            int hundreds, fifties, twenties, tens, fives;

            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("------ADDING NEW TILL WIZARD------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Enter Till Name:");
            newName = Console.ReadLine();

            Console.WriteLine("How many hundreds in the cash deck?");
            hundreds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many fifties in the cash deck?");
            fifties = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many twenties in the cash deck?");
            twenties = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many tens in the cash deck?");
            tens = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many fives in the cash deck?");
            fives = Convert.ToInt32(Console.ReadLine());


        }

        public void viewTill()
        {

        }

        public void enterTill()
        {

        }
    }
}
