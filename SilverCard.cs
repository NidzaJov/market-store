namespace MarketStore
{
    public class SilverCard : ICard
    {
        public double InitialDiscountRate { get; set; }
        public double Turnover { get; set; }
        public string? Owner { get; set; }
        public SilverCard(double turnover)
        {
            InitialDiscountRate = 2;
            Turnover = turnover;
        }
        public (double, double, double, double) ReturnPurchaseDetails(double purchaseValue)
        {
            double actualDiscountRate = Turnover > 300 ? 3.5 : 0;
            double discount = purchaseValue * actualDiscountRate / 100;
            double total = purchaseValue - discount;
            return (purchaseValue, actualDiscountRate, discount, total);
        }
    }
}
