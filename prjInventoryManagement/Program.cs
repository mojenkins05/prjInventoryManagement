using System;
using System.Collections.Generic;
using System.Linq;

namespace prjInventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of products
            List<Product> inventory = new List<Product>
            {
                new Product(1, "Laptop", 5, 999.99m),
                new Product(2, "Mouse", 25, 29.99m),
                new Product(3, "Keyboard", 8, 79.99m),
                new Product(4, "Monitor", 15, 299.99m),
                new Product(5, "USB Cable", 3, 12.99m)
            };

            Console.WriteLine("=== INVENTORY MANAGEMENT SYSTEM ===\n");

            // Display all products
            Console.WriteLine("All Products:");
            foreach (var product in inventory)
            {
                Console.WriteLine($"  {product}");
            }//(Troelsen and Japikse, 2022)

            // Use extension method to calculate total inventory value
            decimal totalValue = inventory.CalculateTotalValue();
            Console.WriteLine($"\nTotal Inventory Value: ${totalValue:F2}");

            // Use extension method to filter low stock products
            var lowStockProducts = inventory.FilterLowStock();
            Console.WriteLine("\nLow Stock Products (less than 10 items):");
            foreach (var product in lowStockProducts)
            {
                Console.WriteLine($"  {product}");
            } //(Troelsen and Japikse, 2022)

            // Use LINQ with anonymous types
            Console.WriteLine("\nProduct Selection (Anonymous Types):");

            // LINQ query that creates anonymous types with product name and price
            // Reference: Microsoft C# Documentation on Anonymous Types
            // https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types
            var productSelections = from product in inventory
                                    select new
                                    {
                                        ProductName = product.Name,
                                        ProductPrice = product.Price,
                                        InStock = product.Quantity > 0
                                    };

            foreach (var selection in productSelections)
            {
                Console.WriteLine($"  Name: {selection.ProductName}, Price: ${selection.ProductPrice}, Available: {selection.InStock}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        //(Troelsen and Japikse, 2022)
    }
}
//Troelsen, A. and Japikse, P. (2022) Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming. 11th ed. New York