using System;

namespace prjInventoryManagement
{
    /// <summary>
    /// Custom type representing a product in inventory
    /// </summary>
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, int quantity, decimal price)
        {
            ID = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }//(Troelsen and Japikse, 2022)

        public override string ToString()
        {
            return $"{ID}: {Name} - Stock: {Quantity} - Price: ${Price}";
        }
    }//(Troelsen and Japikse, 2022)
}//Troelsen, A. and Japikse, P. (2022) Pro C# 10 with .NET 6: Foundational Principles and Practices in Programming. 11th ed. New York