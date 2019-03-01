using System;
using System.Collections.Generic;
using myApp.List;

namespace myApp.Class
{
    public class FirstClass
    {
        public static void TestAccount()
        {
            //测试
            try
            {
                var account = new BankAccount("samuel", 100);
                account.MakeDeposit(500,DateTime.Now, "Rent money.");
                account.MakeWithdrawal(420,DateTime.Now, "get money.");
                account.getAllTransactionHistories();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        private static int accountNumberSeed = 123456789;
        private List<Transaction> allTransaction = new List<Transaction>();
        private List<Transaction> transactionHistories = new List<Transaction>();
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransaction)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        public BankAccount(string name,decimal initBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            this.Owner = name;
            MakeDeposit(initBalance,DateTime.Now, "initial balance.");
        }

        public void MakeDeposit(decimal amount,DateTime date,string note)
        {
            if (amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount,date,note);
            allTransaction.Add(deposit);
            transactionHistories.Add(deposit);
            Console.WriteLine($"remain amount is:{Balance}");
        }

        public void MakeWithdrawal(decimal amount,DateTime date,string note)
        {
            if (amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"amount of withdrawal must be positive!");
            }
            if (Balance-amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal!");
            }
            var withdrawal = new Transaction(-amount,date,note);
            allTransaction.Add(withdrawal);
            transactionHistories.Add(withdrawal);
            Console.WriteLine($"remain amount is:{Balance}");
        }

        public List<Transaction> getAllTransactionHistories()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Date\tAmount\tNote");
            foreach (var oneHistory in this.transactionHistories)
            {
                report.AppendLine($"{oneHistory.Date}\t{oneHistory.Amount}\t{oneHistory.Notes}");
            }
            Console.WriteLine(report.ToString());
            return this.transactionHistories;
        }
    }

    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        public Transaction(decimal amount,DateTime date,string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }
    }
}