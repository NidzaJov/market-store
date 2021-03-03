namespace MarketStore
{
    public class SilverCard : ICard
    {
        public double InitialDiscountRate { get; set; }
        public double Turnover { get; set; }
        public SilverCard(double turnover)
        {
            InitialDiscountRate = 2;
            Turnover = turnover;
        }

        public PurchaseDetails ReturnPurchaseDetails(double purchaseValue)
        {
            double actualDiscountRate = 0;

            if (Turnover > 300)
            {
                actualDiscountRate = 3.5;
            }

            double discount = purchaseValue * actualDiscountRate / 100;
            double total = purchaseValue - discount;
            return new PurchaseDetails(purchaseValue, actualDiscountRate, discount, total);
        }
    }



}
