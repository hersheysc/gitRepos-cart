using ProductWCFtestClient.ProductServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductWCFtestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            var products = client.GetAllProducts();
            Console.WriteLine("Show the Products in the store");
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductID + "  " + item.ProductName + "  " + item.UnitPrice);
                
            }
            Console.ReadLine();

        }
    }
}
