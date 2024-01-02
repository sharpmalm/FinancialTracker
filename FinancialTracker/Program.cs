namespace FinancialTracker;

using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Press 1 to enter income or 2 to exit!");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    IncomeHandler handler = new IncomeHandler();
                    handler.ToString();
                    break;
                case "2":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;

            }

        }
        //IncomeHandler handler = new IncomeHandler();
        //handler.ToString();
    }
}
        
  