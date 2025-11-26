using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotATM.Services
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }  // "Deposit" or "Withdraw"
        public int Amount { get; set; }
        public int BalanceAfter { get; set; }

        public Transaction(string type, int amount, int balanceAfter)
        {
            Date = DateTime.Now;
            Type = type;
            Amount = amount;
            BalanceAfter = balanceAfter;
        }

        public override string ToString()
        {
            return $"{Date:yyyy-MM-dd HH:mm:ss} - {Type}: ${Amount} (Balance: ${BalanceAfter})";
        }
    }

    public class Account
    {
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public List<Transaction> TransactionRecords { get; set; }

        public Account(string accountNumber, string password)
        {
            AccountNumber = accountNumber;
            Password = password;
            Balance = 0;
            TransactionRecords = new List<Transaction>();
        }
    }

    public class AccountService
    {
        private static List<Account> accounts = new List<Account>();

        // Create new account
        public bool CreateAccount(string accountNumber, string password)
        {
            if (accounts.Any(a => a.AccountNumber == accountNumber))
                return false;

            accounts.Add(new Account(accountNumber, password));
            return true;
        }

        // Verify login
        public bool VerifyPassword(string accountNumber, string password)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            return account != null && account.Password == password;
        }

        // Deposit money
        public bool Deposit(string accountNumber, int amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null || amount <= 0) return false;

            account.Balance += amount;
            account.TransactionRecords.Add(new Transaction("Deposit", amount, account.Balance));
            return true;
        }

        // Withdraw money
        public bool Withdraw(string accountNumber, int amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null || amount <= 0 || account.Balance < amount) return false;

            account.Balance -= amount;
            account.TransactionRecords.Add(new Transaction("Withdraw", amount, account.Balance));
            return true;
        }

        // Get current balance
        public int GetBalance(string accountNumber)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            return account?.Balance ?? 0;
        }

        // Change password
        public bool ChangePassword(string accountNumber, string oldPassword, string newPassword)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null || account.Password != oldPassword) return false;

            account.Password = newPassword;
            return true;
        }

        // Get transaction history
        public List<Transaction> GetTransactionRecords(string accountNumber)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            return account?.TransactionRecords ?? new List<Transaction>();
        }
    }
}
