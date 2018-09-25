using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicOperationServiceClient client = new BasicOperationServiceClient();
            var result1 = client.SearchForKeyword("ол");
            var result2 = client.GetManyCheapestInCity(new string[] {"Яблоко", "Сахар", "Молоко"}, "Минск");
            Console.WriteLine();
        }
    }
}
