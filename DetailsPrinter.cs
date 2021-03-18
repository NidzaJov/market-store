using System;
using System.Globalization;

namespace MarketStore
{
    public class DetailsPrinter
    {
        public void PrintDetails(ICard card, double purchaseValue)
        {
             (_, double actualDiscountRate, double discount, double total) = card.ReturnPurchaseDetails(purchaseValue);
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.CurrencyGroupSeparator = "";
            Console.WriteLine(" Purchase value: {0} \n Discount rate: {1}% \n Discount: {2} \n Total: {3}", 
                purchaseValue.ToString("C2", nfi), 
                actualDiscountRate.ToString("N1", nfi), 
                discount.ToString("C2", nfi), 
                total.ToString("C2", nfi));
        }
    }
}
