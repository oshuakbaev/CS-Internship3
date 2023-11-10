using System;
namespace Module10PracticeProject
{
    public class Worker : IWorker
    {
        public void Work(House house)
        {
            if (house.Basement == null)
            {
                house.Basement = new Basement();
                house.Basement.Build();
            }
            else if (house.Walls.Count < 4)
            {
                var wall = new Wall();
                wall.Build();
                house.Walls.Add(wall);
            }
            else if (house.Door == null)
            {
                house.Door = new Door();
                house.Door.Build();
            }
            else if (house.Windows.Count < 4)
            {
                var window = new Window();
                window.Build();
                house.Windows.Add(window);
            }
            else if (house.Roof == null)
            {
                house.Roof = new Roof();
                house.Roof.Build();
            }
        }
    }


    public class TeamLeader : IWorker
    {
        public void Work(House house)
        {
            Console.WriteLine("Construction Report:");
            Console.WriteLine($"Basement: {(house.Basement != null ? "Completed" : "Not Completed")}");
            Console.WriteLine($"Walls: {house.Walls.Count}/4");
            Console.WriteLine($"Door: {(house.Door != null ? "Completed" : "Not Completed")}");
            Console.WriteLine($"Windows: {house.Windows.Count}/4");
            Console.WriteLine($"Roof: {(house.Roof != null ? "Completed" : "Not Completed")}");
        }
    }


}

