using System;
using System.Linq;

namespace PasswordGeneratorAndChecker
{
    class Program
    {
        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        static void Main(string[] args)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz%$*&!?./^@#+=-";
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";
            Random rdm = new Random();
            // Declare variables and then initialize to zero.
            int length = 0;
            int score = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Password generator and checker by Pataxsa");
            Console.WriteLine("-----------------------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("[1] Generate my password");
            Console.WriteLine("[2] Check if my password is strong");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nEnter a password length\nExemple: 10");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Enumerable.Repeat(chars, length).Select(s => s[rdm.Next(s.Length)]).ToArray());
                    break;
                case "2":
                    Console.WriteLine("\nEnter a password to check\nExemple: mypassword");
                    string password = Console.ReadLine();
                    if (password.Length >= minLength)
                    {
                        score++;
                    }
                    if (Contains(password, lowercase))
                    {
                        score++;
                    }
                    if (Contains(password, uppercase))
                    {
                        score++;
                    }
                    if (Contains(password, numbers))
                    {
                        score++;
                    }
                    if (Contains(password, specialChars))
                    {
                        score++;
                    }

                    switch (score)
                    {
                        case 5:
                            Console.WriteLine("\nPassword Status:");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Your password is extremely strong.\n");
                            Console.ResetColor();
                            break;
                        case 4:
                            Console.WriteLine("\nPassword Status:");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your password is very strong.\n");
                            Console.ResetColor();
                            Console.WriteLine("Password Problems:");
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (password.Length < minLength)
                            {
                                Console.WriteLine("The length of your password is less than 8.");
                            }
                            if (!Contains(password, lowercase))
                            {
                                Console.WriteLine("Your password does not contain lowercase letters.");
                            }
                            if (!Contains(password, uppercase))
                            {
                                Console.WriteLine("Your password does not contain uppercase letters.");
                            }
                            if (!Contains(password, numbers))
                            {
                                Console.WriteLine("Your password does not contain numbers.");
                            }
                            if (!Contains(password, specialChars))
                            {
                                Console.WriteLine("Your password does not contain special characters.");
                            }
                            Console.ResetColor();
                            break;
                        case 3:
                            Console.WriteLine("\nPassword Status:");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your password is strong.\n");
                            Console.ResetColor();
                            Console.WriteLine("Password Problems:");
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (password.Length < minLength)
                            {
                                Console.WriteLine("The length of your password is less than 8.");
                            }
                            if (!Contains(password, lowercase))
                            {
                                Console.WriteLine("Your password does not contain lowercase letters.");
                            }
                            if (!Contains(password, uppercase))
                            {
                                Console.WriteLine("Your password does not contain uppercase letters.");
                            }
                            if (!Contains(password, numbers))
                            {
                                Console.WriteLine("Your password does not contain numbers.");
                            }
                            if (!Contains(password, specialChars))
                            {
                                Console.WriteLine("Your password does not contain special characters.");
                            }
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.WriteLine("\nPassword Status:");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Your password is medium.\n");
                            Console.ResetColor();
                            Console.WriteLine("Password Problems:");
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (password.Length < minLength)
                            {
                                Console.WriteLine("The length of your password is less than 8.");
                            }
                            if (!Contains(password, lowercase))
                            {
                                Console.WriteLine("Your password does not contain lowercase letters.");
                            }
                            if (!Contains(password, uppercase))
                            {
                                Console.WriteLine("Your password does not contain uppercase letters.");
                            }
                            if (!Contains(password, numbers))
                            {
                                Console.WriteLine("Your password does not contain numbers.");
                            }
                            if (!Contains(password, specialChars))
                            {
                                Console.WriteLine("Your password does not contain special characters.");
                            }
                            Console.ResetColor();
                            break;
                        case 1:
                            Console.WriteLine("\nPassword Status:");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your password is weak.\n");
                            Console.ResetColor();
                            Console.WriteLine("Password Problems:");
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (password.Length < minLength)
                            {
                                Console.WriteLine("The length of your password is less than 8.");
                            }
                            if (!Contains(password, lowercase))
                            {
                                Console.WriteLine("Your password does not contain lowercase letters.");
                            }
                            if (!Contains(password, uppercase))
                            {
                                Console.WriteLine("Your password does not contain uppercase letters.");
                            }
                            if (!Contains(password, numbers))
                            {
                                Console.WriteLine("Your password does not contain numbers.");
                            }
                            if (!Contains(password, specialChars))
                            {
                                Console.WriteLine("Your password does not contain special characters.");
                            }
                            Console.ResetColor();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You didn't write anything.");
                            Console.ResetColor();
                            break;
                    }
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("\nPress any key to close the password generator...");
            Console.ReadKey();
        }
    }
}