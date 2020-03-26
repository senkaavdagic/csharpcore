using System;
using static System.Console;

namespace CalculateTaxApp
{
    class Program
    {
/// <summary>
/// The function calculates the VAT for a given amount and country. 
/// </summary>
/// <param name="amount"></param>
/// <param name="countryCode"></param>
/// <returns></returns>
        static decimal CalculateTax(decimal amount, string countryCode)
        {
            decimal rate=0.0M;
            rate = countryCode.ToUpper() switch
            {
              "UK"  => 0.1M,
              "DE" => 0.6M,
              "GB" => 0.3M,
              "FR" => 0.4M,
              "BA" => 0.17M,
              "RU" => 0.21M,
              "IT" => 0.13M,
              "BL" => 0.4M,
              _ => 0.32M
            };
            return amount*rate;
        }
        static void RunCalculateTax(){
            Write("Enter the two letter code for the country: ");
            string countryCode = ReadLine();
            Write("Enter the amount you wish to calculate the VAT for: ");
            string amountTxt=ReadLine();
            decimal amount = 0;
           if (decimal.TryParse(amountTxt, out amount))
           {
               WriteLine($"You entered {amount:N0} for country code {countryCode}.");
               WriteLine(CalculateTax(amount, countryCode));
           } else 
           {
               WriteLine("The amount you entered is not a number.");
           }
        }
        static void Main(string[] args)
        {
           RunCalculateTax();
        }
    }
}
