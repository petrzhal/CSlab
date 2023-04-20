namespace Lab6;

public class Train : Transport
{
    public override int MaxSpeed { get; set; }

    public override void Move()
    {
        Console.WriteLine("Train moving");
    }
    
    public Train(string name) : base(name)
    {
        Console.WriteLine("Train constructed");
    }
}