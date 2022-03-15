using Interface;
using System;

namespace MainClass
{
    public class Customer1 : ICustomer
    {
        public void Report()
        {
            Console.WriteLine("This report is for the first type of customer");
        }
    }
 
 
    public class Customer2 : ICustomer
    {
        public void Report()
        {
            Console.WriteLine("This report is for the second type of customer");
        }
    }
}