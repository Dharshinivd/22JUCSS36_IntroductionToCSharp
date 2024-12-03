using System;


public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
}

public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(string make, string model, int year, int payloadCapacity)
        : base(make, model, year)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Payload Capacity: {PayloadCapacity} lbs");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Camry", 2022, 4);
        Truck truck = new Truck("Ford", "F-150", 2022, 3000);

        car.DisplayDetails();
        Console.WriteLine();
        truck.DisplayDetails();
    }
}
