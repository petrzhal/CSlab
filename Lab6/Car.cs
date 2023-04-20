namespace Lab6;

public class Car : Transport
{
    public override int MaxSpeed { get; set; }
    private double TirePressure { get; set; }

    public double Pressure
    {
        get => TirePressure;
        set => TirePressure = value;
    }
    public override void Move()
    {
        Console.WriteLine("Car moving");
    }
    public override void Honk()
    {
        Console.WriteLine("Beep beep");
    }
    public Car(string name) : base(name)
    {
        Console.WriteLine("Car constructed");
    }
}