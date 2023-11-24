using System.Collections.Generic;
using System.Threading;

public class Race
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        car.Finished += CarFinished;
        cars.Add(car);
    }

    private void CarFinished(object sender, EventArgs e)
    {
        var car = sender as Car;
        Console.WriteLine($"{car.Name} финишировал!");
    }

    public void StartRace()
    {
        Console.WriteLine("Гонка началась!");

        bool raceFinished = false;
        while (!raceFinished)
        {
            foreach (var car in cars)
            {
                car.Drive();
                Console.WriteLine($"{car.Name} на расстоянии: {car.Distance}");
                if (car.Distance >= 100)
                {
                    raceFinished = true;
                }
            }
            Thread.Sleep(1000); // Чтобы увидеть прогресс гонки
        }

        Console.WriteLine("Гонка закончена!");
    }
}
