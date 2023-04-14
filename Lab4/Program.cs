namespace Lab4;

internal class Program
{
    private static void Main()
    {
        var hms = Hms.GetInstance();
        hms.District = "D1";
        hms.Tariff = 100;
        hms.Number = 1;
        hms.TenantNum = 10;
        hms.PaidNum = 5;
        Console.WriteLine(hms.TotalDebt());
    }
}