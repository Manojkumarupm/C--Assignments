using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment14
{
    public class Account
    {
        static readonly object _object = new object();
       
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        private double balance { get; set; }
        public Account()
        {
         
        }
        public Account(int AccountNo,string custname,string custAddress,double amount)
        {
            AccountNumber = AccountNo;
            CustomerName = custname;
            CustomerAddress = custAddress;
            balance = amount;
        }
        /// <summary>
        /// Peform withdraw of a given amount
        /// </summary>
        /// <param name="Amount"></param>
        public void Withdraw(double Amount)
        {
            try
            {
                Monitor.Enter(_object);
                if (balance >= Amount)
                {
                    balance -= Amount;
                    Console.WriteLine("Amount " + Amount + "  debited from the Account " + AccountNumber + " of " + CustomerName + " Remaining balance : " + balance);
                }
                else
                {
                    Console.WriteLine(" Not a valid Transaction . Account " + AccountNumber + " don't have enough balance ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Captured " + ex.Message);
            }
            finally
            {
                Monitor.Exit(_object);
            }
        }
        /// <summary>
        /// Perform Deposit of the given Amount
        /// </summary>
        /// <param name="Amount"></param>
        public void Deposit(double Amount)
        {
            try
            {
                Monitor.Enter(_object);
                if (Amount > 0d)
                {
                    balance += Amount;
                    Console.WriteLine("Amount " + Amount + "  Credited to the Account " + AccountNumber + " of " + CustomerName + " Remaining balance : " + balance);
                }
                else
                {
                    Console.WriteLine(" Not a valid Transaction . Amount should be positive value");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Captured " + ex.Message);
            }
            finally
            {
                Monitor.Exit(_object);
            }
        }
    }
}
