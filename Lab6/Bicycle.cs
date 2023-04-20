namespace Lab6;

public sealed class Bicycle : Transport
{
    public override int MaxSpeed { get; set; }
    public override void Move()
    {
        Console.WriteLine("Bicycle is moving.");
    }

    public Bicycle(string name) : base(name)
    {
        Console.WriteLine("Bicycle constructed");
    }
}