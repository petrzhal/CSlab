namespace Lab5;

public class Tariff
{
    private int water { get; set; }
    private int electricity { get; set; }
    private int gas { get; set; }

    public int Water
    {
        get => water;
        set => water = value;
    }
    public int Electricity
    {
        get => electricity;
        set => water = value;
    }
    public int Gas
    {
        get => gas;
        set => gas = value;
    }

    public Tariff(int water, int electricity, int gas)
    {
        this.water = water;
        this.electricity = electricity;
        this.gas = gas;
    }
    public Tariff()
    {
        water = 0;
        electricity = 0;
        gas = 0;
    }
    public Tariff Payment()
    {
        return this;
    }
}