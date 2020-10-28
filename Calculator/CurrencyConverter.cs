using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class CurrencyConverter
    {
        public void DisplayMenu()
        {
            Console.WriteLine(" 1. Convert USD to Euro\n 2. Convert USD to British Pound Sterling\n 3. Convert USD to Japanese Yen\n 4. Convert USD to Canadian Loon\n 5. Exit");

        }

        public double USD_to_EU(double usd)
        {

            return Math.Round(usd * .94, 2);
        }

        public double USD_to_GBP(double usd)
        {
            return Math.Round(usd * .79, 2);
        }

        public double USD_to_JPY(double usd)
        {
            return Math.Round(usd * 113, 2);
        }

        public double USD_to_CAD(double usd)
        {
            return Math.Round(usd * 1.33, 2);
        }


        public void UserEnterAmountToConvert()
        {
            Console.WriteLine("How much would you like to convert?");

        }

        private void MakeConversion(double amount, int userInput)
        {

            if (userInput == 1)
            {

                Console.WriteLine($"${amount} US is equivelent to {USD_to_EU(amount)} Euros.");
            }
            else if (userInput == 2)
            {

                Console.WriteLine($"${amount} US is equivelent to {USD_to_GBP(amount)} British Pound");
            }
            else if (userInput == 3)
            {

                Console.WriteLine($"${amount} US is equivelent to {USD_to_JPY(amount)} Japanese Yen");
            }
            else if (userInput == 4)
            {

                Console.WriteLine($"${amount} US is equivelent to {USD_to_CAD(amount)} Canadian Loons");
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Good Bye");
            }
            else
            {
                Console.WriteLine("Invalid entry.  Please enter a number between 1 and 5.");
            }

        }

        public void ConvertAnotherAmount()
        {
            Console.WriteLine("Do you want to convert another amount?\nYes or No");
            string answer = Console.ReadLine().ToUpper();

            if (answer != "YES" || answer != "NO")
            {
                Console.WriteLine("Please enter a valid response. Yes or No");
                answer = Console.ReadLine().ToUpper();
            }
            if (answer == "YES")
            {
                LetUserConvertCurrency();
            }
            else if (answer == "NO")
            {
                Console.WriteLine("Good Bye");
            }

        }

        public void LetUserConvertCurrency()
        {
            DisplayMenu();
            int userInput = Int32.Parse(Console.ReadLine());
            UserEnterAmountToConvert();
            double amount = double.Parse(Console.ReadLine());
            MakeConversion(amount, userInput);
            ConvertAnotherAmount();
        }

    }
}
