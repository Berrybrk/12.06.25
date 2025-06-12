using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        private int _id  {  get; set; }
        private double _balance { get; set; }
        public static void Main()
        {
            BankAccount account = new BankAccount();

            //private feilds 
            private int id;
            private double balance;

        //public proporties for Id and balance
        public int ID
        {
            get {return _id; }
            set { _id = value; }
        }
        public double Balance
        {
            get {  return _balance; }
            private set { _balance = value; }
        }

        //
        public BankAccount()
        {
            //
            ID = 0;
            Balance = 0;
        }
        //
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                balance += amount; //update the Balance
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;//Update balance
                }
                else
                {
                    Console.WriteLine("Insufficent funds.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }
        //
        public override string ToString()
        {
            return $"Account ID: {ID}, Balance: {Balance:F2}";//Format balance to 2 decimal places
        }
        //
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount(); 
            
            
            account.ID = 1;
            account.Deposit = (15);
            account.Withdraw = (5);

            Console.WriteLine(account.ToString());//
        }
    }
    }

