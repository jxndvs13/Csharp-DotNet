using System;

namespace Basics
{
    class ATM
    {
        public static void Test()
        {
            float balance = 1000.00f;
            char op = '1';
            while (op != '0')
            {
                op = Menu();
                switch (op)
                {
                    case '1':
                        Console.WriteLine("Balance: ${0}", balance);
                        break;
                    case '2':
                        Console.Write("Enter withdraw amount: ");
                        float withdrawAmount = float.Parse(Console.ReadLine());
                        if (withdrawAmount <= balance)
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine("Cash withdrawn.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                        break;
                    case '3':
                        Console.Write("Enter deposit amount: ");
                        float depositAmount = float.Parse(Console.ReadLine());
                        balance += depositAmount;
                        Console.WriteLine("Cash deposit.");
                        break;
                    case '0':
                        Console.WriteLine("Exiting ATM.");
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }
            }
        }

        static char Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to ATM Service.");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("0. Quit");
            Console.Write("Select Operation: ");
            char select = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return select;
        }
    }
    
}