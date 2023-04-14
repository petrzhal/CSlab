namespace Lab5;

internal class Hms
{
    private string district { get; set; }
    private int number { get; set; }
    private Tariff tariff { get; set; }

    private List<Tenant> tenants;
    
    public string District
    {
        get => district;
        set => district = value;
    }

    public int Number
    {
        get => number;
        set => number = value;
    }

    public Tariff GetTariff => tariff.Payment();

    public Tariff SetTariff
    {
        set => tariff = value;
    }

    public Hms()
    {
        tenants = new List<Tenant>();
        district = string.Empty;
        number = 0;
        tariff = new Tariff();
    }

    public void AddTenant(string? name, string? address, PaymentStatus status, int usedWater, int usedElectricity, int usedGas)
    {
        tenants.Add(new Tenant(name, address, status, usedWater, usedElectricity, usedGas));
    }

    public Tenant GetTenantByName(string name)
    {
        foreach (var tenant in tenants.Where(tenant => tenant.Name == name))
        {
            return tenant;
        }
        return new Tenant();
    }
}