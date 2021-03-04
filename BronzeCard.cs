using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class BronzeCard : ICard
    {
        public double InitialDiscountRate { get; set; }
        public double Turnover { get; set; }
        public string? Owner { get; set; }
        public BronzeCard(double turnover)
        {
            InitialDiscountRate = 1;
            Turnover = turnover;
        }
        public PurchaseDetails ReturnPurchaseDetails(double purchaseValue)
        {
            double actualDiscountRate = this.Turnover > 100 && this.Turnover <= 300 ? 1 : this.Turnover > 300 ? 2.5 : 0;
            double discount = purchaseValue * actualDiscountRate / 100;
            double total = purchaseValue - discount;
            return new PurchaseDetails(purchaseValue, actualDiscountRate, discount, total);
        }
    }
}
