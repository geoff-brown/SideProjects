using System;

namespace budget_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Budget Calculator");

            static void TopMenu()
            {
                Console.Write("Please make a selection: ");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Console.WriteLine(" 1: View Current Budget");
                        break;
                    case 2:
                        Console.WriteLine(" 2: Update Budget");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}
