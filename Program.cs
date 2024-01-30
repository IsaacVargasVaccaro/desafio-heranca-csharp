using System;
using System.Globalization;
using System.Collections;
using desafio_heranca_csharp.Entities;

namespace desafio_heranca_csharp
{
    class Program 
    {
    static void Main(string[] args)
    {
        Console.Write("Enter the number os products: ");
        int n = int.Parse(Console.ReadLine());

        List <Product> product = new List<Product>();

        for(int i = 0 ; i < n ; i++)
        {
            Console.WriteLine($"Product #{i+1} data");
            Console.Write("Common, used or imported (c/u/i)? ");
            char data = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            if (data == 'c')
            {
                product.Add(new Product (name, price));
            }
            else if (data == 'i')
            {
                Console.Write("Customs fee: ");
                double customsFee =  double.Parse(Console.ReadLine());
                product.Add(new ImportedProduct(name, price, customsFee));
            }
            else if (data == 'u')
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                product.Add(new UsedProduct (name, price, date));
            }
          }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            
            foreach( Product prod in product)
            {
            Console.WriteLine(prod.priceTag());
            }

        }
    }
}