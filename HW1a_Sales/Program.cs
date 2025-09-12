// HW1a Sales Total

// Your Name: Maddie MacDonald
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What item are you buying?");
            string item = Console.ReadLine();

            Console.WriteLine("What is the quantity of your item?");
            string quantity = Console.ReadLine();
            double quantitydouble;
            quantitydouble = Convert.ToDouble(quantity);

            Console.WriteLine("What is the price of the item?");
            string price = Console.ReadLine();
            double pricedouble;
            pricedouble = Convert.ToDouble(price);

            const double salestax = 0.085;
            double totalsalestax = (pricedouble * quantitydouble)*salestax;
            double salestotal = ((pricedouble*quantitydouble) + totalsalestax);
            double subtotal = (pricedouble*quantitydouble);

            Console.WriteLine("Final subtotal: $" + subtotal.ToString("N2"));
            Console.WriteLine("Final tax: $" + totalsalestax.ToString("N2"));
            Console.WriteLine("Final sales price: $" + salestotal.ToString("N2"));

            Console.ReadKey();

        }
    }
}
