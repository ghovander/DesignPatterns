using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.OpenClosedPrinciple
{
    class ColorSpecification : ISpecification<Product>
    {
        private Color _color;
        internal ColorSpecification(Color color)
        {
            this._color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == _color;
        }
    }
}
