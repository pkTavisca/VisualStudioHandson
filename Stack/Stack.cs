using System;

namespace StackImplementation
{
    public class Stack
    {
        private int[] stack;
        private int size;
        private int index;

        public Stack(int size)
        {
            stack = new int[size];
            this.size = size;
            index = 0;
        }

        public Stack() : this(10) { }

        public int[] GetStack()
        {
            return stack;
        }

        public int GetIndex()
        {
            return index;
        }

        public void Push(int num)
        {
            if (index >= size)
            {
                throw new Exception("Stack Full, Cannot Push.");
            }
            stack[index++] = num;
        }

        public int Pop()
        {
            if (index <= 0)
            {
                throw new Exception("Stack Empty, Cannot Pop.");
            }
            return stack[--index];
        }

        override
        public string ToString()
        {
            string str = "[";
            for (int i = 0; i < index; i++)
            {
                str += stack[i] + " ";
            }
            str += "]";
            return str;
        }
    }
}
