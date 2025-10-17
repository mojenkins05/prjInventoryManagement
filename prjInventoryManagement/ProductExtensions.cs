using System;
using System.Collections.Generic;
using System.Linq;

namespace prjInventoryManagement
{
    /// <summary>
    /// Extension methods for List<Product>
    /// Reference: Microsoft C# Documentation on Extension Methods
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
    /// </summary>
    public static class ProductExtensions
    {
        // Extension method to calculate total inventory value
        public static decimal CalculateTotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Quantity * p.Price);
        }//(Troelsen and Japikse, 2022)

        // Extension method to filter low stock products (less than 10 items)
        public static List<Product> FilterLowStock(this List<Product> products, int threshold = 10)
        {
            return products.Where(p => p.Quantity < threshold).ToList();
        }
    }//(Troelsen and Japikse, 2022)
}
//Troelsen, A. and Japikse, P. (2022) Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming. 11th ed. New York