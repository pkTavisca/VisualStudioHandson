using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class Queue
    {
        private int[] arr;
        private int index;
        private int size;

        public Queue(int sizeOfQueue)
        {
            size = sizeOfQueue;
            index = 0;
            arr = new int[size];
        }

        public Queue() : this(10) { }

        public int GetIndex()
        {
            return index;
        }

        public int GetSize()
        {
            return size;
        }

        override
        public string ToString()
        {
            string str = "[";
            for (int i = 0; i < index; i++)
            {
                str += arr[i] + " ";
            }
            str += "]";
            return str;
        }

        public void Enqueue(int num)
        {
            if (index >= size)
            {
                throw new Exception("Queue full, cannot enqueue.");
            }
            for (int i = index - 1; i >= 0; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[0] = num;
            index++;
        }

        public int Dequeue()
        {
            if (index <= 0)
            {
                throw new Exception("Queue empty, cannot dequeue.");
            }
            return arr[--index];
        }
    }
}
