using System;
using System.Net;
using System.Net.Mail;

namespace SMTP
{

    class Program
    {
        static void Main(string[] args) {


            //Console.WriteLine("введите путь к вашему файлу:");
            //string path = Console.ReadLine();
            
            Sending();
            char choice;
            do
            {
                Console.WriteLine("Want to message again? (y/n)");
                choice = Char.Parse(Console.ReadLine().ToLower());
                Sending();

            }
            while (choice == 'y');
            
            
            static void Sending()

            {

                Console.WriteLine("Введите логин:");
                string username = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();
                Console.WriteLine("Введите домейн:");
                string domain = Console.ReadLine();

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(username, password,domain);

                //client.Host = Console.ReadLine();
                //Console.WriteLine("Порт: ");
                //client.Port =  Int32.Parse(Console.ReadLine());

                

                Console.Write("Кому:");
                SmtpClient client2 = new SmtpClient();
                //client2.Host = Console.ReadLine();
                client.Credentials = new NetworkCredential();

                Console.WriteLine("Тема: ");
                string theme = Console.ReadLine();

                Console.WriteLine("Сообщение:");
                string message = Console.ReadLine();

                client.Send(client.Host, client2.Host, theme, message);
            }






        }
    }
  
}