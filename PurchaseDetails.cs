namespace MarketStore
{
    public class PurchaseDetails
    {
        public double PurchaseValue { get; set; }
        public double ActualDiscountRate { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public PurchaseDetails(double purchaseValue, double actualDiscountRate, double discount, double total)
        {
            PurchaseValue = purchaseValue;
            ActualDiscountRate = actualDiscountRate;
            Discount = discount;
            Total = total;
        }
    }
}
