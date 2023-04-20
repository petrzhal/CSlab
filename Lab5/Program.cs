
using Lab5;

internal class Program
{
    private static int Input()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    private static void Main()


    {
        var hms = new Hms();
        Console.WriteLine("Введите данные о тарифе:");

        Console.Write("Введите сумму оплаты за воду: ");
        var water = Input();

        Console.Write("Введите сумму оплаты за электричество: ");
        var electricity = Input();

        Console.Write("Введите сумму оплаты за газ: ");
        var gas = Input();

        hms.SetTariff = new Tariff(water, electricity, gas);

        Console.Write("Введите количество жильцов: ");
        var tenCount = Input();

        for (var i = 0; i < tenCount; i++)
        {
            Console.Clear();
            Console.WriteLine("Введите данные добавляемого жильца:");

            Console.Write("Введите имя: ");
            var name = Console.ReadLine();

            Console.Write("Введите адрес: ");
            var address = Console.ReadLine();

            Console.Write("Введите статус оплаты (оплачено или не оплачено): ");
            var strStatus = Console.ReadLine();
            var status = strStatus.Equals("оплачено") 
                ? PaymentStatus.Paid 
                : PaymentStatus.NotPaid;

            Console.Write("Введите потребленное кол-во воды: ");
            var usedWater = Input();

            Console.Write("Введите потребленное кол-во електричества: ");
            var usedElectricity = Input();

            Console.Write("Введите потребленное кол-во газа: ");
            var usedGas = Input();

            hms.AddTenant(name, address, status, usedWater, usedElectricity, usedGas);
        }

        Console.Write("Введите фамилию того, о ком нужна информация: ");
        var findName = Console.ReadLine();
        var tenant = findName == null ? null : hms.GetTenantByName(findName);
        if (tenant == null) return;
        Console.WriteLine(
            $"Сумма всех потребленных услуг: {tenant.UsedWater + tenant.UsedElectricity + tenant.UsedGas}");
        Console.WriteLine(
            $"Стоимость всех оказанных услуг: {tenant.UsedWater * hms.GetTariff.Water + tenant.UsedElectricity * hms.GetTariff.Electricity + tenant.UsedGas * hms.GetTariff.Gas}");
        Console.WriteLine($"Статус оплаты: {(tenant.Status == PaymentStatus.Paid ? "оплачено" : "не оплачено")}");
        Console.ReadKey();
    }
}