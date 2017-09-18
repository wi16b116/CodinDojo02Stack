using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinDojo02Stack
{
    class AnimalObject
    {
        public string name { get; set; }
        public string color { get; set; }

        public AnimalObject(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public override string ToString()
        {
            return string.Format("This is a {0} and it's color is {1}.", name, color);
        }

    }
}
