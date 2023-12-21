using System;



namespace QupyaSoz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите желаемую длину пароля (от 8 до 32):");
            string inputLength = Console.ReadLine();
            int length = InputValidator.ValidatePasswordLength(inputLength);

            Console.WriteLine("Сколько паролей вы хотите сгенерировать?");
            
            int count;

            try
            {
                string inputCount = Console.ReadLine();
                count = int.Parse(inputCount);
            }
            catch
            {
                throw new Exception("Неправильный ввод в числе паролей");
            }
            
             

            if (length != -1)
            {
                QupyaSozGenerator generator = new QupyaSozGenerator();
                for (int i = 0; i < count; i++)
                {
                    string password = generator.GeneratePassword(length);
                    Console.WriteLine($"Пароль {i + 1}: {password}");
                }
                SecurityAdvisor.DisplaySecurityTips();
            }
            else
            {
                Console.WriteLine("Некорректный ввод длины пароля");
            }
        }
    }



}