using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Concrete;
using DAL.Interface.DTO;

namespace DalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryRepository cr = new CountryRepository();
            // var jskl = cr.GetAll();
            //var res = cr.GetById(new Guid("0a0c816a-5e8f-404c-bc43-c3d76c8d8761"));
            Console.WriteLine("erewwe");

            ProductRepository pr = new ProductRepository();

            List<string> products = new List<string>() { "Мука", "Молоко", "Яйца","Яблоко", "Сахар" };
            //var res = pr.GetNearest(products, 27.46238, 53.90399);
            var res = pr.GetAllProductsInShop(new Guid("b869aea6-a868-4180-b226-6eeac0292525"));

            //Product product = pr.GetCheapestInCity("Молоко", "Минск");
            //pr.GetById(new Guid("14781a9d-80f0-41f5-9a70-c93cd6d6f6dd"));

            //var jklj = pr.GetNearest("Молоко", 27.46238, 53.90399, 0, 5);

            //var sfdjkl = pr.GetCheapestInCity("Молоко", "Гродно", 0, 10);

            ShopRepository sr = new ShopRepository();

            //var rr = pr.GetOpt("Молоко", "Сыр", "Минск");
            //var res32 = sr.GetAllShopsInCity("Минск");

            CityRepository cp = new CityRepository();
            //var jklj = cp.GetAll("Беларусь");

            Console.WriteLine();
        }
    }
}
