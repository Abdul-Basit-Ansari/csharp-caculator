using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void rline()
            {
                Console.ReadLine();
            }

            void divide(double val1, double val2)
            {

                double res = val1 / val2;
                Console.WriteLine($"Num1 Divided By Num2 Is : {res}");
                
            }

            void multiply(double val1, double val2)
            {

                double res = val1 * val2;
                Console.WriteLine($"Num1 Multiply Num2 Is : {res}");
                
            }

            void add(double val1, double val2)
            {

                double res = val1 + val2;
                Console.WriteLine($"Num1 Added By Num2 Is : {res}");
                
            }


            void sub(double val1, double val2)
            {

                double res = val1 - val2;
                Console.WriteLine($"Num1 Subtract By Num2 Is : {res}");
               
            }

            bool loop = true;
            while (loop == true)
            {
                

                Console.Write("Enter A First Number : ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter A Second Number : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 1 For Division , Enter 2 For Multiplication , Enter 3 For Addision , Enter 4 For Subtraction");
                int opr = Convert.ToInt32(Console.ReadLine());
                if (opr == 1)
                {
                    divide(num1, num2);
                }
                else if (opr == 2)
                {
                    multiply(num1, num2);
                }
                else if (opr == 3)
                {
                    add(num1, num2);
                }
                else if (opr == 4)
                {
                    sub(num1, num2);
                }
                else
                {
                    Console.WriteLine("Sorry Please Perform Valid Opration");
                    rline();
                }

                Console.Write("Enter q For quit Enter c For Continue Calculation : ");
                string q = Console.ReadLine();

                if (q == "q" || q == "Q")
                {
                    loop = false;
                }

            }


        }
    }
}