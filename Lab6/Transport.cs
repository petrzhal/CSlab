namespace Lab6;

public abstract class Transport
{
    private string Name { get; }
    public abstract int MaxSpeed { get; set; }
    public abstract void Move();
    public string GetName()
    {
        return Name;
    }
    public virtual void Honk()
    {
        Console.WriteLine("Honk honk");
    }
    protected Transport(string name)
    {
        Name = name;
        Console.WriteLine("Transport constructed");
    }
}