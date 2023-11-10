using System;
namespace Module10PracticeProject
{
    public class House
    {
        public Basement Basement { get; set; }
        public List<Wall> Walls { get; set; }
        public Door Door { get; set; }
        public List<Window> Windows { get; set; }
        public Roof Roof { get; set; }

        // Конструктор и методы для добавления частей дома

        public void DrawHouse()
        {
            if (Basement != null)
                Console.WriteLine(" B ");
            foreach (var wall in Walls)
                Console.Write("W");
            if (Door != null)
                Console.WriteLine("D");
            foreach (var window in Windows)
                Console.Write("O");
            if (Roof != null)
                Console.WriteLine("\n ^ ");
        }

        public bool IsCompleted()
        {
            return Basement != null
                   && Walls.Count == 4
                   && Door != null
                   && Windows.Count == 4
                   && Roof != null;
        }

    }

}

