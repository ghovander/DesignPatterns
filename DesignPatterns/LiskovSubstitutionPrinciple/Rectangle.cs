using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LiskovSubstitutionPrinciple
{
    class Rectangle
    {
        internal virtual int Width { get; set; }
        internal virtual int Height { get; set; }

        internal Rectangle()
        {

        }

        internal Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}
