# Inventory Management System

## Project Overview
This C# console application demonstrates various C# programming concepts including custom types, extension methods, anonymous types, and discusses pointer types.

## Concepts Demonstrated

### 1. Custom Types
- Created a `Product` class with properties: ID, Name, Quantity, and Price

### 2. Extension Methods
- `CalculateTotalValue()`: Calculates the total value of all products in inventory
- `FilterLowStock()`: Filters products that have stock below a specified threshold

### 3. Anonymous Types
- Used LINQ queries to create anonymous types containing product names and prices
- Anonymous types are useful for creating temporary data structures without defining explicit classes

### 4. Pointer Types in C#

**What are pointer types?**
Pointer types in C# are variables that store the memory address of another type rather than the data itself. They use the `*` symbol in their declaration (e.g., `int* ptr`).

**When are they used?**
Pointer types are used in specific scenarios including:
- Interoperability with unmanaged code or system APIs
- Performance-critical code where direct memory manipulation is necessary
- Working with large data structures in memory-sensitive applications
- System-level programming and device drivers

**Why do they require unsafe context?**
Pointer operations require an `unsafe` context because:
1. **Memory Safety**: C# is a memory-safe language, but pointers bypass this safety
2. **Garbage Collector**: Pointers can interfere with the garbage collector's ability to manage memory
3. **Type Safety**: Pointers can violate C#'s type safety guarantees
4. **Security**: Unsafe code could potentially create security vulnerabilities

The `unsafe` keyword explicitly tells the compiler and developer that the code may have potential risks and requires careful handling. Unsafe code must be compiled with the `/unsafe` compiler option.

**Example of pointer usage:**
```csharp
unsafe 
{
    int value = 10;
    int* pointer = &value;
    Console.WriteLine(*pointer); // Output: 10
}
