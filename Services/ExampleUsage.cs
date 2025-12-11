namespace dotATM.Services
{
    class ExampleUsage
    {
        public static void ExampleUsageMain()
        {
            AccountService service = new AccountService();

            Console.WriteLine("=== ATM Simulator Console Test ===\n");

            // 1. Create accounts
            Console.WriteLine("1. Creating accounts...");
            bool created1 = service.CreateAccount("1001", "pass123");
            bool created2 = service.CreateAccount("1002", "mypass");
            bool created3 = service.CreateAccount("1001", "duplicate"); // Should fail

            Console.WriteLine($"Account 1001 created: {created1}");
            Console.WriteLine($"Account 1002 created: {created2}");
            Console.WriteLine($"Account 1001 duplicate: {created3} (should be false)\n");

            // 2. Verify passwords
            Console.WriteLine("2. Testing password verification...");
            bool verify1 = service.VerifyPassword("1001", "pass123");
            bool verify2 = service.VerifyPassword("1001", "wrongpass");
            bool verify3 = service.VerifyPassword("9999", "pass123");

            Console.WriteLine($"Account 1001 with correct password: {verify1}");
            Console.WriteLine($"Account 1001 with wrong password: {verify2}");
            Console.WriteLine($"Non-existent account: {verify3}\n");

            // 3. Deposit money
            Console.WriteLine("3. Making deposits...");
            service.Deposit(1000);
            service.Deposit(500);
            service.Deposit(2000);

            Console.WriteLine($"Account 1001 balance: ${service.GetBalance()}");
            Console.WriteLine($"Account 1002 balance: ${service.GetBalance()}\n");

            // 4. Withdraw money
            Console.WriteLine("4. Making withdrawals...");
            bool withdraw1 = service.Withdraw(300);
            bool withdraw2 = service.Withdraw(5000); // Should fail - insufficient funds

            Console.WriteLine($"Withdraw $300 from 1001: {withdraw1}");
            Console.WriteLine($"Withdraw $5000 from 1001: {withdraw2} (should be false - insufficient funds)");
            Console.WriteLine($"Account 1001 balance after withdrawal: ${service.GetBalance()}\n");

            // 5. View transaction records
            Console.WriteLine("5. Transaction history for account 1001:");
            var transactions = service.GetTransactionRecords();
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"  {transaction}");
            }
            Console.WriteLine();

            // 6. Change password
            Console.WriteLine("6. Changing password...");
            bool passChange1 = service.ChangePassword("1001", "pass123", "newpass456");
            bool passChange2 = service.ChangePassword("1001", "pass123", "fail"); // Should fail - old password wrong

            Console.WriteLine($"Password changed with correct old password: {passChange1}");
            Console.WriteLine($"Password changed with wrong old password: {passChange2}");
            Console.WriteLine($"Login with new password: {service.VerifyPassword("1001", "newpass456")}\n");

            // 7. Final balances
            Console.WriteLine("7. Final account summary:");
            Console.WriteLine($"Account 1001 - Balance: ${service.GetBalance()}");
            Console.WriteLine($"Account 1002 - Balance: ${service.GetBalance()}");

            Console.WriteLine("\n=== Test Complete ===");
            Console.ReadLine();
        }
    }
}