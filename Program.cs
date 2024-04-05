using System;
using System.Collections.Generic;
using EtiquetaCsharp.Entities;
namespace EtiquetaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a lista de funcionarios
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i =1; i<= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(typeProduct == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customFee));
                }else if(typeProduct == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
