using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bank
    {
        private int accountCounter = 0; // Счетчик для генерации номеров счетов

        public Account OpenAccount(Client client, decimal initialDeposit)
        {
            var accountNumber = ++accountCounter; // Генерация нового номера счета
            var password = "password"; // Простое создание пароля, здесь можно реализовать более безопасное создание пароля
            var account = new Account(accountNumber, password, initialDeposit);
            return account;
        }
    }
}

