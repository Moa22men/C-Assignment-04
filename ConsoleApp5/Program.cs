using System;

namespace ConsoleApp5
{
    class changename
    {
        public string Name;
    }
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

        static void Name1(changename p)
        {
            p.Name = "Moamen";
        }

        static void Name2(ref changename p)
        {
            p = new changename();
            p.Name = "Abdelrahman";
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

            #region Q2
            changename person = new changename();
            person.Name = "Ali";

            Name1(person);
            Console.WriteLine("Name1: " + person.Name); // the output will be Moamen

            Name2(ref person);
            Console.WriteLine("Name2: " + person.Name); // the output will be Abdelrahman
            #endregion
        }
    }
}
