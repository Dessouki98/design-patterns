// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

interface IVehicle
{
    void drive(string msg);
}

class Car : IVehicle
{
    public void drive(string msg)
    {
        Console.WriteLine("Car drive" + msg);
    }
}

class Bike : IVehicle
{
    public void drive(string msg)
    {
        Console.WriteLine("Bike drive" + msg);
    }
}

class Truck : IVehicle
{
    public void drive(string msg)
    {
        Console.WriteLine("Truck drive" + msg);
    }
}

class VehicleFactory
{
    public IVehicle CreateVehicle(string vehicle)
    {
        switch (vehicle)
        {
            case "car": return new Car();
            case "bike": return new Bike();
            case "truck": return new Truck();
            default: throw new ArgumentException("Unknown vehicle type");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IVehicle vehicle = new VehicleFactory().CreateVehicle("bike");
        vehicle.drive(" zzz");
    }
}