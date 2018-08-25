using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService.CalculatorWebServiceSoapClient client;

            client =  new CalculatorService.CalculatorWebServiceSoapClient();

            Console.WriteLine("2 + 3 = {0}", client.Add(2, 3));
            Console.WriteLine("10 / 5 = {0}", client.Div(10, 5));
        }
    }
}
