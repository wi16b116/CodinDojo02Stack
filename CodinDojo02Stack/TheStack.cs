using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinDojo02Stack
{
    class TheStack<T>
    {
        private StackElement<T> currentElement;

        public void push(T item)
        {
            if (currentElement == null)
            {
                currentElement = new StackElement<T>() { ValueOfElement = item, successor = null };
            }
            else
            {
                StackElement<T> temp = new StackElement<T>() { ValueOfElement = item, successor = currentElement };
                currentElement = temp;
            }
        }

        public T Pop()
        {
            if (currentElement != null)
            {
                T temp = currentElement.ValueOfElement;
                currentElement = currentElement.successor;
                return temp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public T Peek()
        {
            if (currentElement != null)
            {
                return currentElement.ValueOfElement;
            }
            else
            {
                return default(T);
            }
        }
    }
}
