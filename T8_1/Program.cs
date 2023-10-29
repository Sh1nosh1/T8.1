using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T8_1
{
    internal class Program
    {
        //Task 1,2
        //Calling an empty Func method without returning values to compute the function y = x².

        /*static void Func()
        {
            Write($"x = ");
            int x = Convert.ToInt32(ReadLine());
            double y = Math.Pow(x, 2);
            WriteLine($"y = {y}");
        }*/


        //Task 3
        //Convert the program so that the Func method calculates the value of the expression:

        /*static double Func(double x)
        {
            return (3 * Math.Pow(x, 2) + 8 * x - 10) / 15;
        }*/


        //Task 4
        //Make a table of the values of the function y = 5x² - 2x +1 on the interval [-5; 5] in steps h = 2 using the complementary method.

        /*static double Func(double x)
        {
            return 5 * Math.Pow(x, 2) - 2 * x + 1;
        }*/


        //Task 5
        //Write an additional method to calculate the function:

        /*static double Func(double x)
        {
            return x < 5 ? (4 * Math.Pow(x, 2) + 1) / (x - 5) : 3 * Math.Pow(x, 2) - 2;
        }*/


        //Task 6
        //Create an application that outputs the sum, subtraction, multiplication, and division of two input input data values.

        /*public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Diff(int x, int y)
        {
            return x - y;
        }
        public static double Div(int x, int y)
        {
            return (double)x / y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }*/


        //Homework

        //Task 1
        //Finding the maximum value of two integer variables a, b. (as well as the third value of c)

        /*public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }*/


        //Task 2
        //Calculate the arithmetic mean of n valid numbers.

        /*public static int Func(string[] split, int count)
        {
            return count / split.Length;
        }*/


        //Task 3
        //Make a table of values of the function y = 4x² + 5x - 10 on the interval [-9; 9] with step h = 3

        /*static double Func(double x)
        {
            return 4 * Math.Pow(x, 2) + 5 * x - 10;
        }*/

        static void Main(string[] args)
        {
            try
            {
                //Task 1,2
                //Calling an empty Func method without returning values to compute the function y = x².

                /*Write($"Enter n: ");
                int n = Convert.ToInt32(ReadLine());
                for (int i = 0; i <= n; i++)
                {
                    Func();
                }*/


                //Task 3
                //Convert the program so that the Func method calculates the value of the expression:

                /*Write("Enter x: ");
                double x = Convert.ToDouble(ReadLine());
                double y = Func(x);
                WriteLine($"\ny = {y:f2}");*/


                //Task 4
                //Make a table of the values of the function y = 5x² - 2x + 1 on the interval [-5; 5] in steps h = 2 using the complementary method.

                /*double x = -5;
                double y;
                WriteLine("Table of the values: \nx:\ty:");
                for( ; x <= 5; x += 2)
                {
                    WriteLine($"x = {x}\ty = {Func(x)}");
                }*/


                //Task 5
                //Write an additional method to calculate the function:

                /*Write("Enter x: ");
                int x = Convert.ToInt32(ReadLine());
                double y = Func(x);
                WriteLine($"y= {y}");*/


                //Task 6
                //Create an application that outputs the sum, subtraction, multiplication, and division of two input input data values.

                /*Write("Enter x: ");
                int x = Convert.ToInt32(ReadLine());
                Write("Enter y: ");
                int y = Convert.ToInt32(ReadLine());
                int result = Sum(x, y);
                WriteLine($"Result sum: {result}");
                int result1 = Diff(x, y);
                WriteLine($"Result difference: {result1}");
                double result2 = Div(x, y);
                WriteLine($"Result divide: {result2:f2}");
                int result3 = Mult(x, y);
                WriteLine($"Result multiplication: {result3}");*/


                //Homework

                //Task 1
                //Finding the maximum value of two integer variables a, b. (as well as the third value of c)

                /*Write("Enter a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("Enter b: ");
                int b = Convert.ToInt32(ReadLine());
                Write("Enter с: ");
                int c = Convert.ToInt32(ReadLine());
                int max = Max(Max(a, b), c);
                Write($"Maximum value: {max}");*/


                //Task 2
                //Calculate the arithmetic mean of n valid numbers.

                /*Write("Enter the quantity of numbers you want to enter: ");
                int n = Convert.ToInt32(ReadLine());
                int[] numbers = new int[n];
                int count = 0;
                WriteLine();
                for(int i = 0; i <= numbers.Length - 1; i++)
                {
                    Write($"Enter {i+1} number: ");
                    numbers[i] = Convert.ToInt32(ReadLine());
                    count += numbers[i];
                }

                int arithmetic = Func(n, count);

                Write($"\nThe arithmetic mean: {arithmetic}");*/

                //With string and .Split

                /*Write("Enter the numbers with a space: ");
                string numbers = ReadLine();
                string[] split = numbers.Split(' ');
                int count = 0;

                for (int i = 0; i <= split.Length - 1; i++)
                {
                    count += Convert.ToInt32(split[i]);
                }
                int arithmetic = Func(split, count);

                Write($"\nThe arithmetic mean: {arithmetic}");*/

                //Task 3
                //Make a table of values of the function y = 4x² + 5x - 10 on the interval [-9; 9] with step h = 3

                /*double x = -9;
                double y;
                WriteLine("Table of the values: \nx:\ty:");
                for (; x <= 9; x += 3)
                {
                    WriteLine($"x = {x}\ty = {Func(x)}");
                }*/

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
