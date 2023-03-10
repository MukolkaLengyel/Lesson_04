using System;
using System.Diagnostics.CodeAnalysis;

class Program
{

    //Overloads
    static int Mult(int a, int b)
    {
        return a * b;
    }

    static int Mult(int a, int b, int c)
    {
        return a + b + c;
    }

    static double Mult(double a, double b)
    {
        return a * b;
    }


    static void Main(string[] args)
    {
        int sum1 = 'a';
        int sum2 = 'b';
        int sum3 = 'c';

        sum3 = maxValue(sum1, sum2);
        PrintResult(sum3);

        sum3 = minValue(sum1, sum2);
        printResult(sum3);

        //Overload settings
        int result = Mult(2, 3, 4); // Result from int Mult overload
        double result1 = Mult(3.4, 2.3);// Result from double Mult overload
        Console.WriteLine("Result of int overloads is: " + result);
        Console.WriteLine("Result of double overloads is: " + result1);

        //try of TrySumIfOdd inicialization in console
        int boolSum1 = 'a';
        int boolSum2 = 'b';
        bool sum4 = false;

        sumIsOdd(Convert.ToInt32(sum4));

        //Method that will return max value among all the parameters
        static int maxValue(int sum1, int sum2)
        {
            if (sum1 > sum2)
            {

            }

            return sum1 + sum2;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Your max value result is: " + result);
        }

        //Method that will return max value among all the parameters
        static int minValue(int sum1, int sum2)
        {
            if (sum1 < sum2)
            {

            }

            return sum1 - sum2;
        }

        static void printResult(int result2)
        {
            Console.WriteLine("Your min value result is: " + result2);
        }

        //Method TrySumIfOdd
        static bool TrySumIfOdd(int boolSum1, int boolSum2, out int sum4)
        {
            sum4 = 0;
            bool isOdd = sum4 % 2 == 1;
            return isOdd;
        }
        static void sumIsOdd (int result3)
        {
            Console.WriteLine("Your odd sum result is: " + result3);
        }
    }

}
