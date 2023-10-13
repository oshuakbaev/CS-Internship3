using System;
namespace module7Practice
{
    class Program

    {
        // Метод, генерирующий исключение
        static void MethodWithException()
        {
            throw new InvalidOperationException("Ошибка в MethodWithException");
        }

        // Метод, вызывающий другой метод и перехватывающий исключение
        static void CallingMethod()
        {
            try
            {
                MethodWithException();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Исключение перехвачено в CallingMethod: " + ex.Message);
                // Если нужно, можно "поднять" исключение дальше по стеку вызовов:
                // throw;
            }
        }

        static void Main(string[] args)
        {
            CallingMethod();
        }

    }
}