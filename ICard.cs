using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public interface ICard
    {
        double InitialDiscountRate { get; set; }
        double Turnover { get; set; }
        string? Owner { get; set; }
        (double, double, double, double) ReturnPurchaseDetails(double PurchaseValue);
    }
}
