using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComplexStringApp
{
    public class ComplexCollection
    {
        private Stack stack;
        private Stack<ComplexNumber> genStack;

        public ComplexCollection()
        {
            stack = new Stack();
            genStack = new Stack<ComplexNumber>();
        }

        public void Add(ComplexNumber num)
        {
            stack.Push(num);
            genStack.Push(num);
        }

        public string ShowStack()
        {
            StringBuilder sb = new StringBuilder();

            foreach (object obj in stack)
                sb.AppendLine(((ComplexNumber)obj).ToString());

            return sb.ToString();
        }

        public string ShowGenStack()
        {
            StringBuilder sb = new StringBuilder();

            foreach (ComplexNumber num in genStack.Reverse())
                sb.AppendLine(num.ToString());

            return sb.ToString();
        }





















        public ComplexNumber Remove()
        {
            stack.Pop();
            return genStack.Pop();
        }
    }
}