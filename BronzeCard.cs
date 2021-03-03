using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class BronzeCard : ICard
    {
        public BronzeCard(double turnover)
        {
            InitialDiscountRate = 1;
            Turnover = turnover;
        }
        public double InitialDiscountRate { get; set; }
        public double Turnover { get; set; }

        public PurchaseDetails ReturnPurchaseDetails(double purchaseValue)
        {
            double actualDiscountRate = 0;
            if (this.Turnover > 100 && this.Turnover <= 300)
            {
                actualDiscountRate = 1;
            }
            if (Turnover > 300)
            {
                actualDiscountRate = 2.5;
            }

            double discount = purchaseValue * actualDiscountRate / 100;
            double total = purchaseValue - discount;
            return new PurchaseDetails(purchaseValue, actualDiscountRate, discount, total);
        }
    }



}
