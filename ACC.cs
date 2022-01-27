using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACC
{
        class Account
        {
            public long AccNo;
            public string Name;
            public string AccType;
            public string TransactionType;
            public int Amount;
            public float balance;

            public Account(long accountno, string name, string acctype, string transaction, int amount)
            {
                AccNo = accountno;
                Name = name;
                AccType = acctype;
                TransactionType = transaction;
                Amount = amount;
            }
            public void Credit(int amt)
            {
                balance = balance + amt;
            }
            public void Debit(int amt)
            {
                balance = balance - amt;
            }
            public void update()
            {
                if (TransactionType == "Deposit")
                {
                    Credit(Amount);
                }
                else if (TransactionType == "Withdraw")
                {
                    Debit(Amount);
                }
            }

            public void BalanceofAccount()
            {
                Console.WriteLine("Enter Account balance before transaction: ");
                balance = float.Parse(Console.ReadLine());
            }
            public void show()
            {
                Console.WriteLine($"Name : {Name}");
                Console.WriteLine($"Account Number : {AccNo}");
                Console.WriteLine($"Account Type : {AccType}");
                Console.WriteLine($"Transacation Type : {TransactionType}");
                Console.WriteLine($"Balance : {balance}");
            }

        }

        class Program
        {
            static void Main(string[] args)
            {

                Account Ac = new Account(927960, "Geetha", "Saving", "Deposit", 4000);
                //Ac.balance = 80000;
                Ac.BalanceofAccount();
                Ac.update();
                Ac.show();
                Console.WriteLine(" ");
                Account Ac1 = new Account(967854, "Hemanth", "Loan", "Withdraw", 5000);
                //Ac1.balance = 100000;
                Ac1.BalanceofAccount();
                Ac1.update();
                Ac1.show();
                Console.Read();
        }
    }
}
