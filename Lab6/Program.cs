
using System.Runtime.InteropServices.JavaScript;
using Lab6;

internal class Program
{
    public static void Main(string[] args)
    {
        var car = new Car("Toyota")
        {
            MaxSpeed = 180,
            Pressure = 2.5
        };
        Console.WriteLine($"Name: {car.GetName()}");
        Console.WriteLine($"Max speed: {car.MaxSpeed}");
        Console.WriteLine($"Tire pressure: {car.Pressure}");
        car.Honk();
        
        var train = new Train("Train1")
        {
            MaxSpeed = 300
        };
        Console.WriteLine($"Name: {train.GetName()}");
        Console.WriteLine($"Max speed: {car.MaxSpeed}");
        train.Honk();
    }
}