namespace Lab4
{
    internal class Hms
    {
        private static Hms? instance;
        private string district { get; set; }
        private int number { get; set; }
        private Tariff tariff { get; }
        private int tenantNum { get; set; }
        private int paidNum { get; set; }

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
        public int Tariff
        {   
            get => tariff.Payment;
            set => tariff.ChangePayment(value);
        }
        public int TenantNum
        {
            get => tenantNum;  
            set => tenantNum = value;
        }
        public int PaidNum
        {
            get => paidNum;
            set => paidNum = value;
        }
        private Hms()
        {
            district = string.Empty;
            number = 0;
            tariff = new Tariff();
            tenantNum = 0;
            paidNum = 0;
        }
        public int TotalDebt()
        {
            return (tenantNum - paidNum) * tariff.Payment;
        }
        public static Hms GetInstance()
        {
             return instance ??= new Hms();
            //return instance;
        }
    }
}