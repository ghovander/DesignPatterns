using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OpenClosedPrinciple
{
    class ProductFilter
    {
        internal static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var product in products)
            {
                if (product.Size == size) yield return product;
            }
        }

        internal static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.Color == color) yield return product;
            }
        }
    }
}
