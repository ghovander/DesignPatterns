using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OpenClosedPrinciple
{
    class Product
    {
        internal string Name { get; set; }
        internal Color Color { get; set; }
        internal Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }

            Name = name;
            Color = color;
            Size = size;
        }
    }

    enum Color
    {
        Red,
        Green,
        Blue
    }

    enum Size
    {
        Small,
        Medium,
        Large,
        Yuge
    }
}
