using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Value(int a)
        {
            a = 5;
        }

        static void Ref(ref int a)
        {
            a = 5;
        }
        static void Main(string[] args)
        {
            #region Q1
            // By Value: Changes inside the function doesn't effect on the original variable.
            // By Reference: Changes inside the function effect on the original variable.
            int b = 10;

            Value(b);
            Console.WriteLine("Change By Value: " + b); // the output will be 10

            Ref(ref b);
            Console.WriteLine("Change By Ref: " + b); // the output will be 5
            #endregion
        }
    }
}
