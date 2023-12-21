using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QupyaSoz
{
    public class InputValidator
    {
        public static int ValidatePasswordLength(string input)
        {
            if (int.TryParse(input, out int length) && length >= 8 && length <= 32)
            {
                return length;
            }
            return -1; // Ошибка валидации
        }
    }

}
