﻿using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int x = 0;
            int y = 0;
            int choice = 0;

            do {
                Console.Clear();
                Console.WriteLine("1: Multiply (*)");
                Console.WriteLine("2: Divide (/)");
                Console.WriteLine("3: Add (+)");
                Console.WriteLine("4: Subtract(-)");
                Console.WriteLine("5: Exit calculator\n");

                try {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                    
                        case 1:
                        Console.WriteLine("\nEnter the first number:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter the second number:");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n{x} * {y} = {c.Multi(x, y)}");
                        Console.WriteLine("\nPress Enter to continue..");
                        Console.ReadLine();
                            break;

                        case 2:
                        /*do {
                            Console.WriteLine("Du har valgt dividér. Indtast dit første tal:");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("og det andet tal:");
                            y = Convert.ToInt32(Console.ReadLine());
                            if (y == 0) Console.WriteLine("Du kan ikke dividere med nul, idiot. Brug et andet tal!");
                        } while (y == 0);*/
                        try
                        {
                            Console.WriteLine("\nEnter the first number:");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter the second number:");
                            y = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"\n{x} / {y} = {c.Divide(x, y)}");
                            Console.WriteLine("\nPress Enter to continue..");
                            Console.ReadLine();
                            }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("\nYou can't divide by 0");
                            Console.WriteLine("\nPress Enter to continue..");
                            Console.ReadLine();
                            }
                            break;

                        case 3:
                        Console.WriteLine("\nEnter the first number:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter the second number:");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n{x} + {y} = {c.Add(x, y)}");
                        Console.WriteLine("\nPress Enter to continue..");
                        Console.ReadLine();
                            break;

                        case 4:
                        Console.WriteLine("\nEnter the first number:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nEnter the second number:");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"\n{x} - {y} = {c.Subtract(x, y)}");
                        Console.WriteLine("\nPress Enter to continue..");
                        Console.ReadLine();
                            break;

                        case 5:
                            Console.WriteLine("\nExiting");
                           
                        break;

                        default:
                        Console.WriteLine("\nWrong input. Press Enter to continue");
                        Console.ReadLine();
                        break;
                    }
                }
                catch(FormatException) {
                    Console.WriteLine("\nEnter a number");
                }
            } while(choice != 5);
        }
    }
}
