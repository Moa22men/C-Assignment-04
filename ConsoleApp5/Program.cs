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

            #region Q3
            int SumAndSub(int n1, int n2, int n3, int n4)
            {
                return (n1 + n2) - (n3 + n4);
            }

            Console.Write("Enter 4 numbers: ");
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int Num3 = int.Parse(Console.ReadLine());
            int Num4 = int.Parse(Console.ReadLine());

            int result = SumAndSub(Num1, Num2, Num3, Num4);
            Console.WriteLine("Result = " + result);
            #endregion

            #region Q4
            int Sum(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                return sum;
            }
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number " + num + " is: " + Sum(num));
            #endregion
        }
    }
}
