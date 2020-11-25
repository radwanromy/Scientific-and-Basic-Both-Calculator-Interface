using System;

namespace TestInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator Interface");
            Console.WriteLine();
            BasicCalc b = new BasicCalc();
            Console.WriteLine("||Summation Result||");
            Console.WriteLine();
            b.sum(10,5);
            b.printStates();
            Console.WriteLine("||Subtraction Result||");
            Console.WriteLine();
            b.sub(10,5);
            b.printStates();
            Console.WriteLine("||Multiplication Result||");
            Console.WriteLine();
            b.multiplication(10,5);
            b.printStates();
            Console.WriteLine("||Division Result||");
            Console.WriteLine();
            b.division(10, 5);
            b.printStates();

        }
    }
}
