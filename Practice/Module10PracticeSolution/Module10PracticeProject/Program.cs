using System;
using System.Collections.Generic;
using Module10PracticeProject;

namespace HouseConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание дома
            House house = new House
            {
                Walls = new List<Wall>(),
                Windows = new List<Window>()
            };

            // Создание бригады строителей
            var workers = new List<Worker>
            {
                new Worker(),
                new Worker(),
                new Worker() // Можно добавить столько работников, сколько хотим
            };

            // Создание бригадира
            TeamLeader teamLeader = new TeamLeader();

            // Процесс строительства
            bool isCompleted = false;
            while (!isCompleted)
            {
                foreach (var worker in workers)
                {
                    worker.Work(house);
                    if (house.IsCompleted())
                    {
                        isCompleted = true;
                        break;
                    }
                }

                // Бригадир делает отчет
                teamLeader.Work(house);
            }

            // Отображение завершенного дома
            Console.WriteLine("House construction is completed!");
            house.DrawHouse();
        }
    }
}
