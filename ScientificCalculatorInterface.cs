using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterfaces
{
    interface ScientificCalculatorInterface
    {
      //  int XtoY(int x, int y);
        double division(double x, double y);
        int factorial(int x);
    }
    class SciCal : ScientificCalculatorInterface
    {
        double result;
        public double division(double number1, double number2)
        {
            Console.WriteLine("Divident : " + number1 +" & Divvisor : "+number2);
            if (number1 %number2==0)
            {
                result = number1 / number2;
                Console.WriteLine("Result : " + result);
                return 0;
            }
            else
            {
               int a = Convert.ToInt32(number1 / number2);
               double b = number1 % number2;
                result = number1 / number2;
                Console.WriteLine("Result : "+ result);
               Console.WriteLine("Quotient = " + a+ "  &  Remainder = " + b);
                return 0;
                
            }
        }
        public int factorial(int number)
        {
            Console.WriteLine("Factorial Of Number : "+number);
            int fact = 1;
            for (int x = 1; x <= number; x++)
            {
                fact *= x;
            }
            int r=fact;
            Console.WriteLine("Result : " + r);
            return 0;

        }
        public void printStates()
        {
            Console.WriteLine("Result : " + result);
        }
    }
}
