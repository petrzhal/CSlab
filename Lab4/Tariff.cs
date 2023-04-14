namespace Lab4
{
    internal class Tariff
    {
        private int payment { get; set; }

        public int Payment => payment;

        public Tariff(int payment)
        {
            this.payment = payment;
        }
        public Tariff()
        {
            this.payment = 0;
        }
        public void ChangePayment(int payment)
        {
            this.payment = payment;
        }
    }
}