namespace Lab5;

public class Tenant
{
    private string? name { get; set; }
    private string? address { get; set; }
    private PaymentStatus status { get; set; }
    private int usedWater { get; set; }
    private int usedElectricity { get; set; }
    private int usedGas { get; set; }
    public string? Name
    {
        get => name;
        set => name = value;
    }

    public string? Address
    {
        get => address;
        set => address = value;
    }

    public PaymentStatus Status
    {
        get => status;
        set => status = value;
    }

    public int UsedWater
    {
        get => usedWater;
        set => usedWater = value;
    }
    
    public int UsedElectricity
    {
        get => usedElectricity;
        set => usedElectricity = value;
    }
    
    public int UsedGas
    {
        get => usedGas;
        set => usedGas = value;
    }
    public Tenant()
    {
        name = "";
        address = "";
        status = PaymentStatus.NotPaid;
        usedWater = 0;
        usedElectricity = 0;
        usedGas = 0;
    }
    public Tenant(string? name, string? address, PaymentStatus status, int usedWater, int usedElectricity, int usedGas)
    {
        this.name = name;
        this.address = address;
        this.status = status;
        this.usedWater = usedWater;
        this.usedElectricity = usedElectricity;
        this.usedGas = usedGas;
    }
}