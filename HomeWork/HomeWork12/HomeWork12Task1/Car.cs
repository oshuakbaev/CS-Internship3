using System;

public abstract class Car
{
    public string Name { get; set; }
    public int Speed { get; protected set; }
    public int Distance { get; protected set; }

    public event EventHandler Finished;

    protected Car(string name)
    {
        Name = name;
    }

    public abstract void Drive();

    protected void OnFinish()
    {
        Finished?.Invoke(this, EventArgs.Empty);
    }
}

public class SportsCar : Car
{
    public SportsCar(string name) : base(name) {}

    public override void Drive()
    {
        // Пример логики движения
        Speed = new Random().Next(10, 15);
        Distance += Speed;
        if (Distance >= 100) OnFinish();
    }
}

public class Sedan : Car
{
    public Sedan(string name) : base(name) {}

    public override void Drive()
    {
        Speed = new Random().Next(5, 10);
        Distance += Speed;
        if (Distance >= 100) OnFinish();
    }
}


public class Truck : Car
{
    public Truck(string name) : base(name) { }

    public override void Drive()
    {
        Speed = new Random().Next(1, 7);
        Distance += Speed;
        if (Distance >= 100) OnFinish();
    }

}

public class Bus : Car
{
    public Bus(string name) : base(name) { }

    public override void Drive()
    {
        Speed = new Random().Next(1, 6);
        Distance += Speed;
        if (Distance >= 100) OnFinish();

    }
}