using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
       public static void Main(string[] args)
        {
            /*Queue<int> queue = new Queue<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {

            }
            */

            
            //Hashtable hashtable = new Hashtable();

            //hashtable.Add("alex555","12345");

            //List<AutoShop> shops = new List<AutoShop>();

            //shops.Add(new AutoShop(100, 10000));
            //shops.Add(new AutoShop(120, 10000));
            //shops.Add(new AutoShop(150, 10000));
            //shops.Add(new AutoShop(150, 10000));

            //List<int> list = new List<int>();
            //Random rnd = new Random();  
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(rnd.Next(1, 10));
            //    Console.WriteLine(list[i]);

            //}

            static List<T> InputList<T>()
            {
                List<T> List = new List<T>();
                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {
                    List.Add(rnd.Next(1, 100));

                }
            }
        }
       

           
    }

    //class AutoShop : IComparable<AutoShop>
    //{
    //    public AutoShop(int Speed, double Cost)
    //    {
            
    //    }
    //    public int Speed {  get; set; }
    //    public double Cost { get; set; }

    //    //public int CompareTo(AutoShop obj)
    //    //{

    //    //}
    //}
}