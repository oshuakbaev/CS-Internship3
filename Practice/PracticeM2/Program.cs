using System;
using System.Collections.Generic; 
using System.Linq;
using System.Security.Cryptography.X509Certificates;



namespace AskYourName
{
    class Program{
        static void Main(string[] args){
            // exmpl01();
            //example02();
            // example03();
            // example04(); 
            // example10();
            example12();
        }

        static void exmpl01(){
            Console.WriteLine("3  5  6");
        }

        static void example02(){
            Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");
        }

        static void example03(){
            
          Console.WriteLine("give a cm date:");

          int date = Int32.Parse(Console.ReadLine()); 

          Console.WriteLine("meter: "+ date/100);                                       
        }

        static void example04(){

          int date = 234; 

          date = 234/7; 

          Console.WriteLine(date); 
        }

        // static void example10(){
            
        //     for (int i = 20; i <= 35; i++)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }

        static void example10(){

            for (int i = 10; i <= 35; i++)
            {
                Console.WriteLine(i*i);
            }

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Give a number for start: "); 

            int date = int.Parse(Console.ReadLine());

            for (int i = date; i <= 50; i++)
            {
                Console.Write((i*i*i)+" ");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------");


            Console.WriteLine("Give a number for start: ");
            
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Give a number for end: ");

            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.Write(i+" ");
            }
        }

        static void example11(){
            
            Console.WriteLine("Give a number"); 
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(7*x*x-3*x+4); 
            
        }  


        static void example12(){

            Console.WriteLine("Give me a radius: "); 
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine("длины окружности:" + 2*3.14*radius); 
            Console.WriteLine("площадь:" + 3.14*radius*radius); 
        }

        static void example19(int* a,int* b){
            int temp = a;

            a = b; 
            b = temp; 


        }


    } 

}