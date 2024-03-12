
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the loan amount: ");
                double loanAmount = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the annual interest rate (e.g. 5 for 5%): ");
                double interestRate = Convert.ToDouble(Console.ReadLine()) / 100;

                Console.Write("Enter the loan duration in months: ");
                int loanDuration = Convert.ToInt32(Console.ReadLine());

                double monthlyInterestRate = interestRate * loanDuration;
                double interestAmount = loanAmount * monthlyInterestRate;
                double totalAmount = loanAmount + interestAmount;

                Console.WriteLine("\nLoan Amount: " + loanAmount);
                Console.WriteLine("Interest Rate: " + interestRate * 100 + "%");
                Console.WriteLine("Loan Duration: " + loanDuration);
                Console.WriteLine("Interest Amount: " + interestAmount);
                Console.WriteLine("Total Amount: " + totalAmount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values only.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input out of range. Please enter smaller values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
