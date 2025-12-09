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
        private string currentAccountNumber = "";
        private static List<Account> accounts = new List<Account>();

        // Login
        public bool Login(string accountNumber, string password)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account != null && account.Password == password)
            {
                currentAccountNumber = accountNumber;
                return true;
            }
            return false;
        }


        // Create new account
        public bool CreateAccount(string accountNumber, string password)
        {
            if (accounts.Any(a => a.AccountNumber == accountNumber))
                return false;

            accounts.Add(new Account(accountNumber, password));
            return true;
        }

        //new
        //Verify account existence
        public bool VerifyAccountExistence(string accountNumber)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            return account != null;
        }


        // Verify login
        public bool VerifyPassword(string accountNumber, string password)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            return account != null && account.Password == password;
        }

        // Deposit money
        public bool Deposit(int amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == currentAccountNumber);
            if (account == null || amount <= 0) return false;

            account.Balance += amount;
            account.TransactionRecords.Add(new Transaction("Deposit", amount, account.Balance));
            return true;
        }

        // Withdraw money
        public bool Withdraw(int amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == currentAccountNumber);
            if (account == null || amount <= 0 || account.Balance < amount) return false;

            account.Balance -= amount;
            account.TransactionRecords.Add(new Transaction("Withdraw", amount, account.Balance));
            return true;
        }

        // Get current balance of the logged-in account
        public int GetBalance()
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == currentAccountNumber);
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
        public List<Transaction> GetTransactionRecords()
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == currentAccountNumber);
            return account?.TransactionRecords ?? new List<Transaction>();
        }

        // Transfer money
        public int Transfer(string targetAccountNumber, int amount)
        {
            var sourceAccount = accounts.FirstOrDefault(a => a.AccountNumber == currentAccountNumber);
            var targetAccount = accounts.FirstOrDefault(a => a.AccountNumber == targetAccountNumber);
            
            //狀態 1: 餘額不足
            if (sourceAccount.Balance < amount)
            {
                return 1;
            }

            //狀態 2: 目標帳戶不存在
            if (targetAccount == null)
            {
                return 2;
            }

            //狀態 3: 嘗試轉給自己
            if (sourceAccount.AccountNumber == targetAccount.AccountNumber)
            {
                return 3;
            }

            sourceAccount.Balance -= amount;
            targetAccount.Balance += amount;

            // 雙向記錄交易
            sourceAccount.TransactionRecords.Add(
                new Transaction($"Transfer Out (To: {targetAccountNumber})", amount, sourceAccount.Balance));

            targetAccount.TransactionRecords.Add(
                new Transaction($"Transfer In (From: {sourceAccount.AccountNumber})", amount, targetAccount.Balance));

            return 0;
        }
    }
}
