using System;

namespace Module8HomeWork
{

    // класс индексатора 
    class Indexator
    {
        // создаем одномерный массив 
        public int[] arr = new int[100];

        public int this[int i]
        {
            get { return arr[i]; }

            set { arr[i] = value * value; }

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            
            // здесь мы создаем объект класса индексатора и выводим. 

            Indexator indexator = new Indexator();
            indexator[0] = 5;

            Console.WriteLine($"значение квадратного индексатора: {indexator[0]}");

        }
    }
}