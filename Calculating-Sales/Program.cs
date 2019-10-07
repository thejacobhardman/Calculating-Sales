using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PRODUCT_ONE_PRICE = 2.98, PRODUCT_TWO_PRICE = 4.50, PRODUCT_THREE_PRICE = 9.98;

            bool isRunning = true;

            double productOneSales = 0.00, productTwoSales = 0.00, productThreeSales = 0.00,
                   productOneTotal = 0.00, productTwoTotal = 0.00, productThreeTotal = 0.00;
            double totalSale = 0.00;

            while (isRunning)
            {
                int product = 0, productQuantity = 0;
                bool userConfirm = false;
                while (userConfirm == false)
                {
                    Console.Write("Enter product number (1-3) (0 to quit program): ");

                    product = Convert.ToInt32(Console.ReadLine());

                    if (product <= 3 && product >= 1)
                    {
                        Console.Write("Enter quantity sold: ");

                        productQuantity = Convert.ToInt32(Console.ReadLine());
                        userConfirm = true;
                    } else if (product == 0)
                    {
                        userConfirm = true;
                        isRunning = false;
                    } else
                    {
                        Console.WriteLine("Please enter a valid selection.");
                    }
                 }

                switch (product)
                {
                    case 1:
                        productOneSales = productQuantity * PRODUCT_ONE_PRICE;
                        productOneTotal += productOneSales;
                        break;
                    case 2:
                        productTwoSales = productQuantity * PRODUCT_TWO_PRICE;
                        productTwoTotal += productTwoSales;
                        break;
                    case 3:
                        productThreeSales = productQuantity * PRODUCT_THREE_PRICE;
                        productThreeTotal += productThreeSales;
                        break;
                    default:
                        break;
                }

                totalSale += (productOneSales + productTwoSales + productThreeSales);
            }

            string productOneDisplay = productOneTotal.ToString("N2"),
                   productTwoDisplay = productTwoTotal.ToString("N2"), 
                   productThreeDisplay = productThreeTotal.ToString("N2"),
                   totalSaleDisplay = totalSale.ToString("N2");

            Console.WriteLine("\nProduct 1: $" + productOneDisplay);
            Console.WriteLine("Product 2: $" + productTwoDisplay);
            Console.WriteLine("Product 3: $" + productThreeDisplay);
            Console.WriteLine("\nTotal Sale: $" + totalSaleDisplay);

            Console.WriteLine("\nPress 'enter' to close the program.");
            Console.ReadLine();
        }
    }
}
