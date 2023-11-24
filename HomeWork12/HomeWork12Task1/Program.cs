class Program
{
    static void Main()
    {
        var race = new Race();

        race.AddCar(new SportsCar("Спортивный автомобиль"));
        race.AddCar(new Sedan("Легковой автомобиль"));
        race.AddCar(new Truck("трактор деда"));
        race.AddCar(new Bus("Скул бас"));

        // Добавьте другие автомобили

        race.StartRace();
    }
}
