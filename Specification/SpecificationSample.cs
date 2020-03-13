using DesignPatterns.Specification;
using DesignPatterns.Specification.ProductFilter;
using System;

namespace DesignPatterns
{
    public interface ISpecificat1ionSample : IPatternSample { }

    public class Specificat1ionSample : ISpecificat1ionSample
    {
        public void Execute()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var filtrMngr = new FilterManager<Product>();

            Console.WriteLine("Green products (new):");
            foreach (var p in filtrMngr.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {p.Name} is green");

            Console.WriteLine("Large products");
            foreach (var p in filtrMngr.Filter(products, new SizeSpecification(Size.Large)))
                Console.WriteLine($" - {p.Name} is large");

            Console.WriteLine("Large blue items");
            foreach (var p in filtrMngr.Filter(products,
              new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }
        }
    }
}
