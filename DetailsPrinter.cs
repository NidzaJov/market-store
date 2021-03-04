using System;
using System.Globalization;

namespace MarketStore
{
    public class DetailsPrinter
    {
        public void PrintDetails(ICard card, double purchaseValue)
        {
            PurchaseDetails details = card.ReturnPurchaseDetails(purchaseValue);
            
            Console.WriteLine(" Purchase value: {0} \n Discount rate: {1}% \n Discount: {2} \n Total: {3}", 
                details.PurchaseValue.ToString("C2",new CultureInfo("en-US")), 
                details.ActualDiscountRate.ToString("F1", new CultureInfo("en-US")), 
                details.Discount.ToString("C2", new CultureInfo("en-US")), 
                details.Total.ToString("C2", new CultureInfo("en-US")));

        }
    }
}
