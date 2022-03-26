using System;
namespace SampleProgram
{
    class ProductOrderList
    {
        static void Main()
        {
            int price1, price2, quantity1, quantity2, amount1, amount2, totalAmount, totalQuantity, discountPercent, taxPercent;
            double discountAmount, taxAmount, netAmount;

            try
            {
                Console.Write("Enter price 1: ");
                price1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter quantity 1: ");
                quantity1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price 2: ");
                price2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter quantity 2: ");
                quantity2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter discount(%): ");
                discountPercent = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter tax(%): ");
                taxPercent = Convert.ToInt32(Console.ReadLine());

                amount1 = price1 * quantity1;
                amount2 = price2 * quantity2;

                totalAmount = amount1 + amount2;
                totalQuantity = quantity1 + quantity2;

                // calculate disount from total amount
                discountAmount = (totalAmount * ((float)discountPercent / 100));
                discountAmount = Math.Round(discountAmount, 2);
                netAmount = totalAmount - discountAmount;

                // calculate tax from discounted amount
                taxAmount = (netAmount * ((float)taxPercent / 100));
                taxAmount = Math.Round(taxAmount, 2);
                netAmount += taxAmount;

                Console.WriteLine("\t\t\tProduct Order List");
                Console.WriteLine("Product Name\tBranch\tCategory\tPrice\tQuantity\tAmount");
                Console.WriteLine("Laptopi5\tLenovo\tLaptop\t\t" + price1 + "\t" + quantity1 + "\t\t" + amount1);
                Console.WriteLine("WirelessKB\tLenovo\tKB\t\t" + price2 + "\t" + quantity2 + "\t\t" + amount2);
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\t\t\tTotal Amount\t" + totalAmount);
                Console.WriteLine("\t\t\t\t\t\tTotal Quantity\t" + totalQuantity);
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\t\t\tDiscount(" + discountPercent +"%)" + "\t" + discountAmount);
                Console.WriteLine("\t\t\t\t\t\tTax(" + taxPercent + "%)" + "\t" + taxAmount);
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\t\t\tNet Amount\t" + netAmount);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid data.");
            }
        }
    }
}
