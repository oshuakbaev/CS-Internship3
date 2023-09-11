using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloClass.HelloMethod();
            
            Console.WriteLine("Введите 2 числа: ");
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            int sum; 

            if (Int32.TryParse(inputA, out int a) && Int32.TryParse(inputB, out int b))
            {
                
                sum = SumOfTwo.SumMethod(a, b);
                Console.WriteLine("Ваша сумма "+sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

    public class SumOfTwo
    {
        public static int SumMethod(int a, int b)
        {
            return a+b;
        }
    }

    public class HelloClass
    {
        static string? FIO;

        public static void HelloMethod()
        {
            Console.WriteLine("Введите ФИО:");
            FIO = Console.ReadLine();
            
            if (FIO != null)
            {
                Console.WriteLine("Приветствую тебя " + FIO + " !");
            }
        }
    }
}
