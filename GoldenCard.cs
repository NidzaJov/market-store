using System;

namespace MarketStore
{
    public class GoldenCard : ICard
    {
        public double InitialDiscountRate { get; set; }
        public double Turnover { get; set; }

        public GoldenCard(double turnover)
        {
            InitialDiscountRate = 2;
            Turnover = turnover;
        }

        public PurchaseDetails ReturnPurchaseDetails(double purchaseValue)
        {
            double actualDiscountRate = 0;

            if (Turnover <= 800)
            {
                actualDiscountRate = InitialDiscountRate + Math.Truncate(Turnover / 100);
            }
            else
            {
                actualDiscountRate = 10;
            }

            double discount = purchaseValue * actualDiscountRate / 100;
            double total = purchaseValue - discount;
            return new PurchaseDetails(purchaseValue, actualDiscountRate, discount, total);
        }
    }



}
