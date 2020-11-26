using System;

namespace TestInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("||||||||||||||Calculator||||||||||||||");
            Console.WriteLine();
            Console.WriteLine("Basic Calculator Interface");
            Console.WriteLine();
            BasicCalc b = new BasicCalc();
            Console.WriteLine("||Summation Function Result||");
            
            b.sum(10,5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("||Subtraction Function Result||");
           // Console.WriteLine();
            b.sub(10,5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("||Multiplication Function Result||");
            //Console.WriteLine();
            b.multiplication(10,5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("||Division Function Result||");
           // Console.WriteLine();
            b.division(10, 5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Scientific Calculator Interface ");
            Console.WriteLine();
            SciCal s = new SciCal();
            Console.WriteLine();
            Console.WriteLine("||Division Function Result||");
            Console.WriteLine();
            s.division(11, 5);
            //b.printStates();
            Console.WriteLine("||Factorial Function Result||");
            Console.WriteLine();
            s.factorial(5);
            Console.WriteLine();
            Console.WriteLine("||X to Y Function Result||");
            Console.WriteLine();
            s.XtoY(100, 500);

        }
    }
}
