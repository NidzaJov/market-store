using System;

namespace MarketStore
{
    public class DetailsPrinter
    {
        public void PrintDetails(ICard card, double purchaseValue)
        {
            PurchaseDetails details = card.ReturnPurchaseDetails(purchaseValue);
            Console.WriteLine(" Purchase value: ${0:F2} \n Discount rate: {1:F1}% \n Discount: ${2:F2} \n Total: ${3:F2}", details.PurchaseValue, details.ActualDiscountRate, details.Discount, details.Total);

        }
    }
}
