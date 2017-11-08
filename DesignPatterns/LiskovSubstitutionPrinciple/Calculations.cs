using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LiskovSubstitutionPrinciple
{
    class Calculations
    {
        internal static int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;
    }
}
