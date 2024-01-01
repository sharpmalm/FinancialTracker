namespace FinancialTracker;

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\vsc\\source\\repos\\FinancialTracker\\FinancialTracker\\entries.txt");
        FileHandler fileHandler = new FileHandler(fileName);
        List<string> entries = fileHandler.ReadFileEntries();

        try
        {
            Console.Write("Enter amount: ");
            string amountString = Console.ReadLine();
            if (amountString != null)
            {
                int amount = int.Parse(amountString);

                Console.Write("Enter date (yyyy-mm-dd): ");
                string dateString = Console.ReadLine();
                if (dateString != null)
                {
                    DateTime date = DateTime.Parse(dateString);

                    Console.Write("Enter description: ");
                    string description = Console.ReadLine();
                    if (description != null)
                    {
                        Income income = new Income(amount, date, description);
                        entries.Add(income.ToString());

                        fileHandler.WriteToFile(entries);
                        Console.WriteLine("Entry added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input format. Please enter a valid description.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input format. Please enter a valid date in yyyy-mm-dd format.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input format. Please enter a valid integer for amount.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input format. Please enter a valid integer for amount and a valid date in yyyy-mm-dd format.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while processing your request.");
            Console.WriteLine(ex.Message);
        }
    }
}
//