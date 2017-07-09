using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueImplementation;

namespace ConsoleApp2
{
    class StackThroughQueuesImplementation
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Queue q1 = new Queue();
            Queue q2 = new Queue();

            do
            {
                Console.WriteLine(q1.ToString());

                Console.WriteLine("Enter Choice\n1.Push\n2.Pop");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    if (q1.GetIndex() >= q1.GetSize())
                    {
                        Console.WriteLine("Stack full, cannot Push.");
                    }
                    else
                    {
                        Console.Write("Enter a number: ");
                        int num = int.Parse(Console.ReadLine());
                        q1.Enqueue(num);
                    }
                }

                else if (choice == 2)
                {
                    if (q1.GetIndex() <= 0)
                        Console.WriteLine("Stack empty, cannot Pop.");
                    else
                    {
                        for (int i = q1.GetIndex(); i > 1; i--)
                        {
                            q2.Enqueue(q1.Dequeue());
                        }
                        int popped = q1.Dequeue();
                        for (int i = 0; i < q2.GetIndex(); i++)
                        {
                            q1.Enqueue(q2.Dequeue());
                        }
                    }
                }

                else if (choice != 0)
                {
                    Console.WriteLine("Invalid Choice. Enter 0 to go exit.");
                }
            } while (choice != 0);
        }
    }
}
