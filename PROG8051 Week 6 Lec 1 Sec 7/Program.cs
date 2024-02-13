
using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpTutorials
{
    class Program
    {
        // how to create a method
        static void welcome()
        {
            Console.WriteLine("Welcome  to Week 6");
        }

        static string welcomeHome()
        {
            return ("Welcome  to Home");
        }

        // how to create a method
        static void welcomeBack(string name = "John", int age = 25)
        {
            Console.WriteLine($"{name} is {age} years old");
        }

        static int add(int a, int b)
        {
            return a + b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
        static int div(int a, int b)
        {
            return a / b;
        }
        static int mul(int a, int b)
        {
            return a * b;
        }

        static int InputValidation(string[,] Accounts)
        {
            Console.WriteLine("Please enter your name: ");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            int rows = Accounts.GetLength(0);
            int cols = Accounts.GetLength(1);

            int userid = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Accounts[i, 0].Equals(username))
                    {
                        if (Accounts[i, 1].Equals(password))
                        {
                            Console.WriteLine("Successful Login");
                            userid = i;
                            break;
                        }
                    };
                }
            }

            return userid;
        }

        static void checkBalance(string[,] Accounts, int userid)
        {
            Console.WriteLine("Your balance is: " + Accounts[userid, 2]);
        }

        static string displayMenu()
        {
            Console.WriteLine("1. Check Balance \n2. Deposit \n3. Withdraw \n4.End");
            Console.WriteLine("Please choose action: ");
            string action = Console.ReadLine();
            return action;
        }

        static void Deposit(string[,] Accounts, int userid)
        {
            Console.WriteLine("Please enter amount: ");
            string amountDepopsit = Console.ReadLine();
            Accounts[userid, 2] = Convert.ToString(Convert.ToInt32(Accounts[userid, 2]) + Convert.ToInt32(amountDepopsit));
            Console.WriteLine("Your balance is: " + Accounts[userid, 2]);
        }



        static void addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void addition(double a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void addition(double a, int b, int c)
        {
            Console.WriteLine(a + b+c);
        }


        static void Main(string[] args)
        {


            addition(7, 80);
            addition(7.5, 80);
            addition(7.5, 80,45);


            // 2D Array
            string[,] Accounts = { { "A", "123", "5000" }, { "B", "1234", "50000" } };

            // step 1 : validation

            int userid = InputValidation(Accounts);



            // Step 2 : Display Menu
            string action = displayMenu();



            // Step 3 : Check Balanse
            if (action == "1")
            {
                checkBalance(Accounts, userid);
            }

            // Step 4 : Deposit
            else if (action == "2")
            {
                Deposit(Accounts, userid);

            }
            // Step 5 : Withdraw
            else if (action == "3")
            {
                Console.WriteLine("Please enter amount: ");
                string amountWithdraw = Console.ReadLine();
                Accounts[userid, 2] = Convert.ToString(Convert.ToInt32(Accounts[userid, 2]) - Convert.ToInt32(amountWithdraw));
                Console.WriteLine("Your balance is: " + Accounts[userid, 2]);
            }
            // Step 6 : End

            else if (action == "4")
            {
                Console.WriteLine("Remove your card ");

            }























            /*


                        Console.WriteLine("Please enter 1st num: ");

                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter 2nd num: ");

                        int num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter operation: ");

                        string op = Console.ReadLine();

                        if (op == "+")
                        {
                            Console.WriteLine(add(num1,num2));
                        }

                        else if (op == "-")
                        {
                            Console.WriteLine(sub(num1, num2));
                        }

                        else if (op == "/")
                        {
                            Console.WriteLine(div(num1, num2));
                        }

                        else if (op == "*")
                        {
                            Console.WriteLine(mul(num1, num2));
                        }

                        else
                        {
                            Console.WriteLine("");
                        }




                        int a = 5;
                        int b = 6;

                        Console.WriteLine($"The result of adding a and b is {add(a, b)}");
                        welcome();
                        Console.WriteLine("-----------");
                        Console.WriteLine(welcomeHome());
                        Console.WriteLine("-----------");



                        welcomeBack("Daniel",24);
                        welcomeBack();



            */
        }
    }
}
