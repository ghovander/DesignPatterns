using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LiskovSubstitutionPrinciple
{
    class Square : Rectangle
    {
        internal override int Width
        {
            set { base.Width = base.Height = value; }
        }

        internal override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
