using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW4
{
    public class Mystack <T> where T: class
    {
        private Stack<T> stack = new Stack<T>();

        public int Count()
        {
            return stack.Count;
        }
        public T Pop()
        {
            return stack.Pop();
        }
        public void push(T item)
        {
            stack.Push(item);
        }
    }
}
