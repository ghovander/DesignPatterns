using DesignPatterns.OpenClosedPrinciple;
using DesignPatterns.SingleResponsibilityPriniciple;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        /// <summary>
        /// Singe Responsibility Principle: Every class has a single responsibility. Hence, a class should have only one reason to change.
        /// </summary>
        private static void ExecuteSingleResponsibilityPrinciple()
        {
            var journal = new Journal();
            journal.AddEntry("I cried today");
            journal.AddEntry("I ate a bug");
            Console.WriteLine(journal);

            var persistence = new Persistence();
            var filename = @"C:\temp\journal.txt";
            persistence.SaveToFile(journal, filename);
            Process.Start(filename);
        }
        /// <summary>
        /// Open Closed Principle: Parts of System should be open for extension, but closed for modification. Code updates should result in new code, no re-written code.
        /// </summary>
        private static void ExecuteOpenClosedPrinciple()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            foreach (var product in ProductFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            var betterFilter = new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach (var p in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }
            Console.WriteLine("Large products:");
            foreach (var p in betterFilter.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine($" - {p.Name} is large");
            }
            Console.WriteLine("Large blue items");
            foreach (var p in betterFilter.Filter(products, new MultipleSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }
        }
    }
}
