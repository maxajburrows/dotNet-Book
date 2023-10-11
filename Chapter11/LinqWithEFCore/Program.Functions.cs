using Packt.Shared;
using Microsoft.EntityFrameworkCore;
using static System.Console;
using SQLitePCL;

partial class Program
{
    static void FilterAndSort()
    {
        SectionTitle("Filter and sort");
        using (Northwind db = new())
        {
            DbSet<Product> allProducts = db.Products;
            IQueryable<Product> processedProducts = allProducts.ProcessSequence();
            IQueryable<Product> filteredProducts = processedProducts
                .Where(product => product.UnitPrice < 10M);
            IOrderedQueryable<Product> sortedAndFilteredProducts = filteredProducts
                .OrderByDescending(product => product.UnitPrice);
            var projectedProducts = sortedAndFilteredProducts
                .Select(product => new
                {
                    product.ProductId,
                    product.ProductName,
                    product.UnitPrice
                });
            WriteLine("Products that cost less than $10:");

            foreach (var p in projectedProducts)
            {
                WriteLine("{0}: {1} costs {2:$#,##0.00}",
                    p.ProductId, p.ProductName, p.UnitPrice);
            }
            WriteLine();
            WriteLine(projectedProducts.ToQueryString());
        }
    }

    static void JoinCategoriesAndProducts()
    {
        SectionTitle("Join categories and products");
        using (Northwind db = new())
        {
            var queryJoin = db.Categories.Join(
                inner: db.Products,
                outerKeySelector: category => category.CategoryId,
                innerKeySelector: product => product.CategoryId,
                resultSelector: (c, p) =>
                    new { c.CategoryName, p.ProductName, p.ProductId })
                .OrderBy(cp => cp.CategoryName);
            foreach (var item in queryJoin)
            {
                WriteLine("{0}: {1} is in {2}.",
                arg0: item.ProductId,
                arg1: item.ProductName,
                arg2: item.CategoryName);
            }
            WriteLine(queryJoin.ToQueryString());
        }
    }

    static void GroupJoinCategoriesAndProducts()
    {
        SectionTitle("Group join categories and products");
        using (Northwind db = new())
        {
            var queryGroup = db.Categories.AsEnumerable().GroupJoin(
                inner: db.Products,
                outerKeySelector: category => category.CategoryId,
                innerKeySelector: product => product.CategoryId,
                resultSelector: (c, matchingProducts) => new
                {
                    c.CategoryName,
                    Products = matchingProducts.OrderBy(p => p.ProductName)
                });
        
            foreach (var category in queryGroup)
            {
                WriteLine("{0} has {1} products.",
                    arg0: category.CategoryName,
                    arg1: category.Products.Count());
                foreach (var product in category.Products)
                {
                    WriteLine($"{product.ProductName}");
                }
            }
        }
    }

    static void AggregateProducts()
    {
        SectionTitle("Aggregate products");
        using (Northwind db = new())
        {
            WriteLine("{0,-25} {1,10}",
                arg0: "Product count:",
                arg1: db.Products.Count());
            WriteLine("{0,-25} {1,10:$#,##0.00}",
                arg0: "Highest product price:",
                arg1: db.Products.Max(p => p.UnitPrice));
            WriteLine("{0,-25} {1,10:N0}",
                arg0: "Sum of units in stock:",
                arg1: db.Products.Sum(p => p.UnitsInStock));
            WriteLine("{0,-25} {1,10:N0}",
                arg0: "Sum of units on order:",
                arg1: db.Products.Sum(p => p.UnitPrice));
            WriteLine("{0,-25} {1,10:$#,##0.00}",
                arg0: "Average unit price:",
                arg1: db.Products.Average(p => p.UnitPrice));
            WriteLine("{0,-25} {1,10:$#,##0.00}",
                arg0: "Value of units in stock:",
                arg1: db.Products.Sum(p => p.UnitPrice * p.UnitsInStock));
        }
    }

    static void CustomExtensionMethods()
    {
        SectionTitle("Custom aggregate extension methods");
        using (Northwind db = new())
        {
            WriteLine("{0,-25} {1,10:N0}",
                "Mean units in stock:",
                db.Products.Average(p => p.UnitsInStock));
            WriteLine("{0,-25} {1,10:$#,##0.00}",
                "Mean unit price:",
                db.Products.Average(p => p.UnitPrice));
            WriteLine("{0,-25} {1,10:N0}",
                "Median units in stock:",
                db.Products.Median(p => p.UnitsInStock));
            WriteLine("{0,-25} {1,10:$#,##0.00}",
                "Median unit price:",
                db.Products.Median(p => p.UnitPrice));
            WriteLine("{0,-25} {1,10:N0}",
                "Mode units in stock:",
                db.Products.Mode(p => p.UnitsInStock));
            WriteLine("{0,-25} {1,10:$#,##0.00}",
                "Mode unit price:",
                db.Products.Mode(p => p.UnitPrice));
        }
    }
}