using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;
using QueueImplementation;

namespace StacksAndQueuesViaArray
{
    class StacksAndQueues
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Enter Choice number:\n1.Stacks\n2.Queues");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Stack stack = new Stack();
                        int stackChoice = 0;
                        do
                        {
                            Console.Write("Enter choice:\n1.Push\n2.Pop");
                            stackChoice = int.Parse(Console.ReadLine());
                            if (stackChoice == 1)
                            {
                                Console.WriteLine("Enter number to push:");
                                int num = int.Parse(Console.ReadLine());
                                try
                                {
                                    stack.Push(num);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            else if (stackChoice == 2)
                            {
                                try
                                {
                                    stack.Pop();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            Console.WriteLine(stack.ToString());
                        } while (stackChoice != 0);
                        break;
                    case 2:
                        Queue q = new Queue();
                        int qChoice = 0;
                        do
                        {
                            Console.WriteLine("Enter choice\n1.Enqueue\n2.Dequeue");
                            qChoice = int.Parse(Console.ReadLine());

                            if (qChoice == 1)
                            {
                                Console.WriteLine("Enter number to enqueue:");
                                int num = int.Parse(Console.ReadLine());
                                try
                                {
                                    q.Enqueue(num);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            else if (qChoice ==2)
                            {
                                try
                                {
                                    q.Dequeue();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            Console.WriteLine(q.ToString());
                        } while (qChoice != 0);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, Enter 0 to quit.");
                        break;
                }
            } while (choice != 0);
        }
    }
}
