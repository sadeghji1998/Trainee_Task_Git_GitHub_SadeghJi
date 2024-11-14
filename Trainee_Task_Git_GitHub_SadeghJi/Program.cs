using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainee_Task_Git_GitHub_SadeghJi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
                new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
                new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
                new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
                new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
            };


            //تمرین 1
            //Category1 بازیابی تمام محصولات  
            // استفاده شده است GroupBy و Where از دستور  Categories.Category1 برای دریافت محصولات  

            var list = products.Where(t => t.Category == Categories.Category1).GroupBy(t => t.Category == Categories.Category1);
            Console.WriteLine("retrieve products under category1:\n");
            foreach (var Group in list)
            {
                foreach (var item in Group)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }

        }
    }
}
