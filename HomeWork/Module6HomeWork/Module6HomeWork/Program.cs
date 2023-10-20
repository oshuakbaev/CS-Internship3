using System;
using Module6HomeWorkLibrary;
using Bankomat;


namespace Module6HomeWorkConsole
{
    class Program
    {
        private static string f;

        static void Main(string[] args)
        {
            /* Задание 1
             * это у нас первое задание здесь мы выводим наши библеотеки
                var person = new Module6HomeWorkLibrary.Person
                {
                    FirstName = "Zhenya",
                    LastName = "Gertzin",
                    Age = 18
                };
                string result = Module6HomeWorkLibrary.PersonProccess.PersonProccessFunction(person);
                Console.WriteLine(result
            */

            /* Задание 2
             *выводим на экран статические данные  
            Console.WriteLine($"минимальный возраст: {Task2.minAge}");
            Console.WriteLine($"максимальный возраст: {Task2.maxAge}");
            Console.WriteLine($"код страны: {Task2.countryCode}");
            */

            /* Задание 3 
            // Создание объектов Bank и Client
            var bank = new Bankomat.Bank();
            var client = new Bankomat.Client { Name = "John Doe" };

            // Открытие счета с начальным депозитом
            var account = bank.OpenAccount(client, 1000m);

            // Вывод информации о счете на консоль
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance}");

            // Внесение дополнительной суммы на счет
            account.Deposit(500m);

            // Вывод обновленного баланса на консоль
            Console.WriteLine($"Updated Balance: {account.Balance}");

            */

            /* Задание 4
            string correctPassword = "1234"; // Предполагаемый пароль
            int attempts = 3; // Количество попыток

            for (int i = 0; i < attempts; i++)
            {
                Console.Write("Введите пароль: ");
                string userInput = Console.ReadLine();

                if (userInput == correctPassword)
                {
                    Console.WriteLine("Пароль введен верно!");
                    return; // Завершение программы при верном вводе пароля
                }
                else
                {
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts - i - 1}");
                }
            }

            Console.WriteLine("Все попытки исчерпаны. Программа завершается.");
        
            */
        }
    
    }
}