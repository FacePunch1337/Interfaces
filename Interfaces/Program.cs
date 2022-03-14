using System;
using System.Collections.Generic;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Classes.Product> products = new List<Classes.Product>();

            products.Add(new Classes.Refrigerator { Name = "Samsung", Price = 100500 });
            products.Add(new Classes.Refrigerator { Name = "Frost", Price = 10500 });
            products.Add(new Classes.Book { Name = "Knuth", Price = 1500 });
            products.Add(new Classes.OldRefrigerator { Name = "Samsung2002", Price = 1340, Discont = 0});
            products.Add(new Classes.OldRefrigerator { Name = "Samsung2003", Price = 1230, Discont = 20 });
            products.Add(new Classes.OldRefrigerator { Name = "Samsung2004", Price = 14320, Discont = 0 });
            products.Add(new Classes.OldRefrigerator { Name = "Samsung2020", Price = 13210, Discont = 21 });
            products.Add(new Classes.OldRefrigerator { Name = "Samsung2021", Price = 100, Discont = 10 });
            products.Add(new Classes.OldBook { Name = "Harry Potter", Price = 14, Discont = 0 });
            products.Add(new Classes.OldBook { Name = "Tom Soer", Price = 13, Discont = 21 });
            products.Add(new Classes.OldBook { Name = "Suzana", Price = 30, Discont = 10 });

            Console.WriteLine("All products");
            foreach (Classes.Product i in products)
                Console.WriteLine(i);

            Console.WriteLine("\nPrintable products: ");
            foreach(Classes.Product i in products)
            {
                if (i is Classes_interfaces.IPrintable)
                {
                    Classes_interfaces.IPrintable ip = i as Classes_interfaces.IPrintable;

                    ip.Print();
                }
            }

            Console.WriteLine("\nOldRefrigerator");
            foreach (Classes.Product i in products)
            {
                if (i is Classes.OldRefrigerator)
                    Console.WriteLine(i);
            }   

            Console.WriteLine("\nDiscont OldRefrigerator");
            foreach (Classes.Product i in products)
            {
                if (i is Classes.OldRefrigerator)
                {
                    Classes.OldRefrigerator ip = i as Classes.OldRefrigerator;
                    Console.WriteLine($"{ip} and that ===> [{ip.OperationDiscount(ip.Discont)}]$");
                }
            }

            Console.WriteLine("\nOldBook");
            foreach (Classes.Product i in products)
            {
                if (i is Classes.OldBook)
                {
                    Classes.OldBook ip = i as Classes.OldBook;
                    ip.Print();
                }
            }
        }
    }
}