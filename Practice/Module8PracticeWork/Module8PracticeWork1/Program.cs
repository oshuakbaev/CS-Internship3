using System;

namespace Module8PracticeWork
{

    public class RangeOfArray
    {
       public int Start {  get; private set; }
       public int End { get; private set; }

        public int[] arr;

        public RangeOfArray(int start, int end)
        {
            Start = start;
            End = end;
            arr = new int[end - start + 1];
        }

        public int this[int index]
        {
            get
            {
                if(index < Start || index > End)
                {
                    throw new IndexOutOfRangeException();
                }

                return arr[index - Start];
            }

            set
            {
                if (index < Start || index > End)
                {
                    throw new IndexOutOfRangeException();
                }

                arr[index - Start] = value;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            RangeOfArray rangeArray = new RangeOfArray(5, 20);
            rangeArray[6] = 56;

            Console.WriteLine($"Value is {rangeArray[6]}");

        }
    }
}