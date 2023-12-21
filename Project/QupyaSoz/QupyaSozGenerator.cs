using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QupyaSoz
{
    // генерация пароля
    public class QupyaSozGenerator
    {
       
        private readonly Random _random = new Random();

        public string GeneratePassword(int length)
        {
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*";
            string allChars = uppercase + lowercase + digits + specialChars;

            return new string(Enumerable.Repeat(allChars, length)
                                        .Select(s => s[_random.Next(s.Length)]).ToArray());
            /* возвращаем сам пароль, создает последовательность,
             выбирает один случайный символ из каждой строки в последовательности, затем создает массив
             а из массива уже в строку */


        }
    }
}
