using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    public delegate int ArithmeticOperation(int num1, int num2);
    internal class Program
    {
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int Diff(int num1,int num2)
        {
            return num1 - num2;
        }
        public static int Mul(int num1,int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1,int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            try
            {
                ArithmeticOperation add = Add;
                ArithmeticOperation diff = Diff;
                ArithmeticOperation mul = Mul;
                ArithmeticOperation div = Div;
                Console.WriteLine("Enter Number 1");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number 2");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nSelect the Operation to Perform\n1. Addition\n2. Substraction\n3. Multiplication\n4. Division\n");
                Console.WriteLine("Which function to perform?");
            again:
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            int result = add(num1, num2);
                            Console.WriteLine($"\nThe Addition of {num1} and {num2} is {result}");
                            break;
                        }
                    case 2:
                        {
                            int result = Diff(num1, num2);
                            Console.WriteLine($"\nThe Substraction of {num1} and {num2} is {result}");
                            break;
                        }
                    case 3:
                        {
                            int result = Mul(num1, num2);
                            Console.WriteLine($"\nThe Multiplication of {num1} and {num2} is {result}");
                            break;
                        }
                    case 4:
                        {
                            int result = Div(num1, num2);
                            Console.WriteLine($"\nThe Division of {num1} and {num2} is {result}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nWrong Option....!!!!\nSelect the Right Option");
                            goto again;
                        }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
