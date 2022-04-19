using System;
namespace SampleProgram
{
    class ProductOrderList
    {
        static void Main()
        {
            ProductOrder productOrder = new();
            productOrder.PrepareOrder();
            productOrder.PrintOrderInfo();

            Console.Read();
        }
    }

    class ProductOrder
    {
        int totalAmount, totalQuantity, discountPercent, taxPercent;
        double discountAmount, taxAmount, netAmount;

        Product product1, product2;

        public void PrepareOrder()
        {
            product1 = new Product
            {
                name = "Laptopi5",
                brand = "Lenovo",
                category = "Laptop"
            };

            product2 = new Product
            {
                name = "WirelessKB",
                brand = "Lenovo",
                category = "KB"
            };

            product1.PrepareData();
            product2.PrepareData();

            discountPercent = InputHelper.GetInt("Enter discount(%): ");
            taxPercent = InputHelper.GetInt("Enter tax(%): ");

            CalculateTotal();
            CalculateDiscount();
            CalculateTax();
        }

        public void PrintOrderInfo()
        {
            Console.WriteLine("\t\t\tProduct Order List");
            Console.WriteLine("Product Name\tBranch\tCategory\tPrice\tQuantity\tAmount");
            Console.WriteLine(product1.name + "\t" + product1.brand + "\t" + product1.category + "\t\t" + product1.price + "\t" + product1.quantity + "\t\t" + product1.amount);
            Console.WriteLine(product2.name + "\t" + product2.brand + "\t" + product2.category + "\t\t" + product2.price + "\t" + product2.quantity + "\t\t" + product2.amount);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t\tTotal Amount\t" + totalAmount);
            Console.WriteLine("\t\t\t\t\t\tTotal Quantity\t" + totalQuantity);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t\tDiscount(" + discountPercent + "%)" + "\t" + discountAmount);
            Console.WriteLine("\t\t\t\t\t\tTax(" + taxPercent + "%)" + "\t" + taxAmount);
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t\tNet Amount\t" + netAmount);
        }

        private void CalculateTotal()
        {
            totalAmount = product1.amount + product2.amount;
            totalQuantity = product1.quantity + product2.quantity;
        }

        // calculate disount from total amount
        private void CalculateDiscount()
        {
            discountAmount = totalAmount * ((float)discountPercent / 100);
            discountAmount = Math.Round(discountAmount, 2);
            netAmount = totalAmount - discountAmount;
        }

        // calculate tax from discounted amount
        private void CalculateTax()
        {
            taxAmount = netAmount * ((float)taxPercent / 100);
            taxAmount = Math.Round(taxAmount, 2);
            netAmount += taxAmount;
        }
    }

    class Product
    {
        public String name, brand, category;
        public int price, quantity, amount;

        private void CalculateAmount()
        {
            amount = price * quantity;
        }

        public void PrepareData()
        {
            price = InputHelper.GetInt("Enter price for " + name +": ");
            quantity = InputHelper.GetInt("Enter quantity for " + name + ": ");

            CalculateAmount();
        }
    }

    // simple helper for getting input from user with safety checks
    class InputHelper
    {
        public static int GetInt(String text)
        {
            int Input = 0;
            bool IsValid;
            do
            {
                try
                {
                    Console.Write(text);
                    Input = Convert.ToInt32(Console.ReadLine());
                    IsValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input! Please try again.");
                    IsValid = false;
                }
            } while (!IsValid);

            return Input;
        }
    }
}
