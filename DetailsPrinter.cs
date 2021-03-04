using System;
using System.Globalization;

namespace MarketStore
{
    public class DetailsPrinter
    {
        public void PrintDetails(ICard card, double purchaseValue)
        {
            PurchaseDetails details = card.ReturnPurchaseDetails(purchaseValue);
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.CurrencyGroupSeparator = "";
            Console.WriteLine(" Purchase value: {0} \n Discount rate: {1}% \n Discount: {2} \n Total: {3}", 
                details.PurchaseValue.ToString("C2", nfi), 
                details.ActualDiscountRate.ToString("N1"), 
                details.Discount.ToString("C2", nfi), 
                details.Total.ToString("C2", nfi));

        }
    }
}
