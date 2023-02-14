using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;
         public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            var userAnswer = Console.ReadLine();
            while (double.TryParse(userAnswer, out double result) == false)
            { 
                Console.WriteLine("Input a number next time please!");
                userAnswer = Console.ReadLine();
            }
            
                double amount = double.Parse(userAnswer);
                balance += amount;
            }
            
        public double GetBalance() 
        { 
            return balance; 
        }
    }
}
