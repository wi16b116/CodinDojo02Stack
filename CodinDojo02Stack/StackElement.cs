using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinDojo02Stack
{
    class StackElement<T>
    {
        public T ValueOfElement { get; set; }
        public StackElement<T> successor { get; set; }
    }
}
