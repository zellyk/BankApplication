using System;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            SavingsAccount sAccount = new SavingsAccount(5.00, 2.0);
            ChequingAccount cAccount = new ChequingAccount(5.00, 2.0);
            GlobalSavings gAccount = new GlobalSavings(5.00, 2.0);

            string userOption = "";

            do
            {
                Console.WriteLine("Bank Menu\n" + 
                                  "A: Savings Account\n" +
                                  "B: Checking Account\n" +
                                  "C: Global Savings Account\n" +
                                  "Q: Exit\n");

                userOption = Console.ReadKey().Key.ToString();
                Console.WriteLine();

                while (userOption != "A" && userOption != "B" && userOption != "C" && userOption != "Q")
                {
                    Console.WriteLine("Enter A, B, C or Q.");
                    userOption = Console.ReadKey().Key.ToString();
                    Console.WriteLine();
                }

                switch (userOption)
                {
                    // SAVINGS MENU
                    case "A":
                        do
                        {

                            Console.WriteLine("\nSavings Account Menu\n" +
                                              "A: Deposit\n" +
                                              "B: Withdrawal\n" +
                                              "C: Close + Report\n" +
                                              "R: Return to Bank Menu\n");

                            userOption = Console.ReadKey().Key.ToString();
                            Console.WriteLine();

                            while (userOption != "A" && userOption != "B" && userOption != "C" && userOption != "R")
                            {
                                Console.WriteLine("Enter A, B, C or R.");
                                userOption = Console.ReadKey().Key.ToString();
                                Console.WriteLine();
                            }

                            switch (userOption)
                            {
                                case "A":

                                    string tempAmount = "";
                                    double depositAmount = -1;
                                    bool validNumber = false;

                                    while (!validNumber)
                                    {
                                        Console.WriteLine("\nEnter a valid amount to deposit.");
                                        tempAmount = Console.ReadLine();

                                        double outNum = -1;
                                        bool isNumeric = Double.TryParse(tempAmount, out outNum);

                                        if (isNumeric && outNum >= 0)
                                        {
                                            depositAmount = outNum;
                                            validNumber = true;
                                        }
                                    }

                                    sAccount.MakeDeposit(depositAmount);
                                    break;
                                case "B":
                                    double withdrawAmount = -1;
                                    validNumber = false;

                                    while (!validNumber)
                                    {
                                        Console.WriteLine("\nEnter a valid amount to withdraw.");
                                        tempAmount = Console.ReadLine();

                                        double outNum = -1;
                                        bool isNumeric = Double.TryParse(tempAmount, out outNum);

                                        if (isNumeric && outNum >= 0)
                                        {
                                            withdrawAmount = outNum;
                                            validNumber = true;
                                        }
                                    }

                                    sAccount.MakeWithdraw(withdrawAmount);
                                    break;
                                case "C":
                                    sAccount.CloseAndReport();
                                    break;
                            }

                        } while (userOption != "R");
                        break;
                    // CHECKINGS MENU
                    case "B":
                        do
                        {
                            Console.WriteLine("\nCheckings Account Menu\n" +
                                              "A: Deposit\n" +
                                              "B: Withdrawal\n" +
                                              "C: Close + Report\n" +
                                              "R: Return to Bank Menu\n");

                            userOption = Console.ReadKey().Key.ToString();
                            Console.WriteLine();

                            while (userOption != "A" && userOption != "B" && userOption != "C" && userOption != "R")
                            {
                                Console.WriteLine("Enter A, B, C or R.");
                                userOption = Console.ReadKey().Key.ToString();
                                Console.WriteLine();
                            }

                            switch (userOption)
                            {
                                case "A":

                                    string tempAmount = "";
                                    double depositAmount = -1;
                                    bool validNumber = false;

                                    while (!validNumber)
                                    {
                                        Console.WriteLine("\nEnter a valid amount to deposit.");
                                        tempAmount = Console.ReadLine();

                                        double outNum = -1;
                                        bool isNumeric = Double.TryParse(tempAmount, out outNum);

                                        if (isNumeric && outNum >= 0)
                                        {
                                            depositAmount = outNum;
                                            validNumber = true;
                                        }
                                    }

                                    cAccount.MakeDeposit(depositAmount);
                                    break;
                                case "B":
                                    double withdrawAmount = -1;
                                    validNumber = false;

                                    while (!validNumber)
                                    {
                                        Console.WriteLine("\nEnter a valid amount to withdraw.");
                                        tempAmount = Console.ReadLine();

                                        double outNum = -1;
                                        bool isNumeric = Double.TryParse(tempAmount, out outNum);

                                        if (isNumeric && outNum >= 0)
                                        {
                                            withdrawAmount = outNum;
                                            validNumber = true;
                                        }
                                    }

                                    cAccount.MakeWithdraw(withdrawAmount);
                                    break;
                                case "C":
                                    cAccount.CloseAndReport();
                                    break;
                            }

                        } while (userOption != "R");
                        break;
                    // GLOBAL SAVINGS MENU
                    case "C":
                        do
                        {
                            Console.WriteLine("\nGlobal Savings Account Menu\n" +
                                              "A: Deposit\n" +
                                              "B: Withdrawal\n" +
                                              "C: Close + Report\n" +
                                              "D: Report Balance in USD\n" +
                                              "R: Return to Bank Menu\n");

                            userOption = Console.ReadKey().Key.ToString();
                            Console.WriteLine();

                            while (userOption != "A" && userOption != "B" && userOption != "C" && userOption != "D" && userOption != "R")
                            {
                                Console.WriteLine("\nEnter A, B, C, D or R.");
                                userOption = Console.ReadKey().Key.ToString();
                                Console.WriteLine();
                            }

                            switch (userOption)
                            {
                                case "A":
                                    string tempAmount = "";
                                    double depositAmount = -1;
                                    bool validNumber = false;

                                    while (!validNumber)
                                    {
                                        Console.WriteLine("\nEnter a valid amount to deposit.");
                                        tempAmount = Console.ReadLine();

                                        double outNum = -1;
                                        bool isNumeric = Double.TryParse(tempAmount, out outNum);

                                        if (isNumeric && outNum >= 0)
                                        {
                                            depositAmount = outNum;
                                            validNumber = true;
                                        }
                                    }

                                    gAccount.MakeDeposit(depositAmount);
                                    break;
                                case "B":
                                    double withdrawAmount = -1;
                                    validNumber = false;

                                    while (!validNumber)
                                    {
                                        Console.WriteLine("\nEnter a valid amount to withdraw.");
                                        tempAmount = Console.ReadLine();

                                        double outNum = -1;
                                        bool isNumeric = Double.TryParse(tempAmount, out outNum);

                                        if (isNumeric && outNum >= 0)
                                        {
                                            withdrawAmount = outNum;
                                            validNumber = true;
                                        }
                                    }

                                    gAccount.MakeWithdraw(withdrawAmount);
                                    break;
                                case "C":
                                    gAccount.CloseAndReport();
                                    break;
                                case "D":
                                    Console.WriteLine(String.Format("\nAccount Balance: USD{0:C2}", gAccount.USValue(0.76335878)));
                                    break;
                            }

                        } while (userOption != "R");
                        break;
                }

            } while (userOption != "Q");


        }
    }
}
