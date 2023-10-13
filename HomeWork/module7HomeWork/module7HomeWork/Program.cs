// это у нас первый таск
//using System;
//using System.Net.Http;

//namespace ExceptionHandlingExample
//{
//    class Program
//    {
//        static async System.Threading.Tasks.Task Main(string[] args)
//        {
//            try
//            {
//                using (HttpClient client = new HttpClient())
//                {
//                    // 1. создаем обьект для отправки запроса
//                    //HttpResponseMessage response = await client.GetAsync("http://nonexistentwebsite.com");
//                    HttpResponseMessage response = await client.GetAsync("https://www.w3schools.com/");

//                    // 2. проверяем на успешность запроса
//                    response.EnsureSuccessStatusCode();

//                    // 3. чтение данные асинхронным методом
//                    string responseData = await response.Content.ReadAsStringAsync();
//                    Console.WriteLine(responseData);
//                }
//            }
//            catch (HttpRequestException e)
//            {
//                Console.WriteLine("Ошибка при запросе: " + e.Message);
//            }
//            finally
//            {
//                Console.WriteLine("Завершение программы.");
//            }
//        }
//    }
//}

// задание 2
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        try
        {
            for (int i = 0; i <= array.Length; i++)  // Попытка обращения к элементу за пределами массива 
            {
                Console.WriteLine(array[i]);
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Исключение: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Завершение обработки массива.");
        }
    }
}


