using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject
{
    class Program
    {
        static int[] stack = new int[10];
        static int stackCtr = 0;

        static int[] queue = new int[10];
        static int qCtr = 0;

        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Enter Choice number:\n1. Stacks\n2.Queues\n3.Queue through Stacks\n4.Stack through Queues");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    int stackChoice = 0;
                    displayArray(stack);
                    do
                    {
                        Console.WriteLine("\n1.Push\n2.Pop");
                        stackChoice = int.Parse(Console.ReadLine());
                        if (stackChoice == 1)
                        {
                            if (stackCtr > 9)
                            {
                                Console.WriteLine("Stack Full.");
                            }
                            else
                            {
                                Console.WriteLine("Enter number to push ");
                                int numToPush = int.Parse(Console.ReadLine());
                                pushToStack(ref stack, ref stackCtr, numToPush);
                            }
                        }
                        else if (stackChoice == 2)
                        {
                            if (stackCtr == 0)
                            {
                                Console.WriteLine("Stack already empty.");
                            }
                            else
                            {
                                popFromStack(ref stack, ref stackCtr);
                            }
                        }
                        else if (stackChoice != 0)
                        {
                            Console.WriteLine("Invalid Choice. Enter 0 to go back.");
                        }
                        displayArray(stack);
                    } while (stackChoice != 0);
                }
                else if (choice == 2)
                {
                    int qChoice = 0;
                    do
                    {
                        displayArray(queue);
                        Console.WriteLine("1.Push\n2.Pop");
                        qChoice = int.Parse(Console.ReadLine());
                        if (qChoice == 1)
                        {
                            if (qCtr == 10)
                            {
                                Console.WriteLine("Queue Full.");
                            }
                            else
                            {
                                Console.WriteLine("Enter number to push.");
                                int numToPush = int.Parse(Console.ReadLine());
                                pushToQueue(ref queue, ref qCtr, numToPush);
                            }
                        }
                        else if (qChoice == 2)
                        {
                            if (qCtr == 0)
                            {
                                Console.WriteLine("Queue empty.");
                            }
                            else
                            {
                                popFromQueue(ref queue, ref qCtr);
                            }
                        }
                        else if (qChoice != 0)
                        {
                            Console.WriteLine("Invalid Choice. Enter 0 to go back.");
                        }
                    } while (qChoice != 0);
                }
                else if (choice == 3)
                {
                    int stqChoice = 0;
                    int[] stack1 = new int[10];
                    int[] stack2 = new int[10];
                    do
                    {
                        displayArray(stack1);
                        Console.WriteLine("\n1.Enqueue\n2.Dequeue");
                        stqChoice = int.Parse(Console.ReadLine());
                        if (stqChoice == 1)
                        {
                            if (getCounter(stack1) == 9)
                            {
                                Console.WriteLine("Queue Full.");
                            }
                            else
                            {
                                Console.WriteLine("Enter a number to push.");
                                int num = int.Parse(Console.ReadLine());
                                enQ(ref stack1, ref stack2, num);
                            }
                        }
                        else if (stqChoice == 2)
                        {
                            if (getCounter(stack1) == 0)
                            {
                                Console.WriteLine("Queue Empty.");
                            }
                            else
                            {
                                deQ(ref stack1);
                            }
                        }
                        else if (stqChoice != 0)
                        {
                            Console.WriteLine("Invalid Choice. Enter 0 to go back.");
                        }
                    } while (stqChoice != 0);
                }
                else if (choice == 4)
                {
                    int qtsChoice = 0;
                    int[] q1 = new int[10];
                    int[] q2 = new int[10];
                    do
                    {
                        Console.WriteLine("\n1.Push\n2.Pop");
                        qtsChoice = int.Parse(Console.ReadLine());
                        if (qtsChoice == 1)
                        {
                            if (getCounter(q1) >= 10)
                            {
                                Console.WriteLine("Stack Full.");
                            }
                            else
                            {
                                Console.WriteLine("Enter a number to push.");
                                int num = int.Parse(Console.ReadLine());
                                pushThroughQ(ref q1, num);
                            }
                        }
                        else if (qtsChoice == 2)
                        {
                            if (getCounter(q1) <= 0)
                            {
                                Console.WriteLine("Stack Empty.");
                            }
                            else
                            {
                                popThroughQ(ref q1);
                            }
                        }
                        else if (qtsChoice != 0)
                        {
                            Console.WriteLine("Invalid Choice. Enter 0 to go back.");
                        }
                    } while (qtsChoice != 0);
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Invalid Choice. Enter 0 to exit.");
                }
            } while (choice != 0);
        }

        public static void pushThroughQ(ref int[] q1, int num)
        {
            pushThroughQ(ref q1, num);
        }

        public static void popThroughQ(ref int[] q1)
        {
            int sc = getCounter(q1);
            popFromStack(ref q1, ref sc);
        }

        public static void enQ(ref int[] s1, ref int[] s2, int num)
        {
            emptyStackInto(ref s2, ref s1);
            int sc1 = getCounter(s1);
            pushToStack(ref s1, ref sc1, num);
            emptyStackInto(ref s1, ref s2);
        }

        public static int deQ(ref int[] s1)
        {
            int sc1 = getCounter(s1);
            return popFromStack(ref s1, ref sc1);
        }

        public static void emptyStackInto(ref int[] sTo, ref int[] sFrom)
        {
            while (getCounter(sFrom) > 0)
            {
                int sc1 = getCounter(sTo);
                int sc2 = getCounter(sFrom);
                pushToStack(ref sTo, ref sc1, popFromStack(ref sFrom, ref sc2));
            }
        }

        public static int getCounter(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) return i;
            }
            return arr.Length;
        }

        public static void pushToQueue(ref int[] q, ref int qc, int numToPush)
        {
            for (int i = q.Length - 1; i > -1; i--)
            {
                if (q[i] == 0)
                    continue;
                else
                    q[i + 1] = q[i];
            }
            q[0] = numToPush;
            qc++;
        }

        public static int popFromQueue(ref int[] q, ref int qc)
        {
            int popped = q[qc - 1];
            q[--qc] = 0;
            return popped;
        }

        public static void pushToStack(ref int[] s, ref int sc, int noToPush)
        {
            s[sc] = noToPush;
            sc++;
        }

        public static int popFromStack(ref int[] s, ref int sc)
        {
            int popped = s[sc - 1];
            s[--sc] = 0;
            return popped;
        }

        public static void displayArray(int[] inputToDisplay)
        {
            String toReturn = "[";
            for (int i = 0; i < inputToDisplay.Length; i++)
            {
                if (inputToDisplay[i] == 0)
                    continue;
                toReturn += inputToDisplay[i] + " ";
            }
            toReturn += "]";
            Console.WriteLine(toReturn);
        }
    }
}
