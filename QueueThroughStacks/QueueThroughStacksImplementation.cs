using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementation;

namespace QueueThroughStacks
{
    class QueueThroughStacksImplementation
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Stack mainStack = new Stack();
            Stack altStack = new Stack();
            do
            {
                Console.WriteLine("Enter choice: \n1.Enqueue\n2.Dequeue");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    try
                    {
                        Console.WriteLine("Enter the number: ");
                        int num = int.Parse(Console.ReadLine());
                        mainStack.Push(num);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (choice == 2)
                {
                    try
                    {
                        for (int i = mainStack.GetIndex() - 1; i > 0; i--)
                        {
                            altStack.Push(mainStack.Pop());
                        }
                        mainStack.Pop();
                        for (int i = altStack.GetIndex() - 1; i >= 0; i--)
                        {
                            mainStack.Push(altStack.Pop());
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (choice != 0)
                {
                    Console.WriteLine("Invalid Input. Enter 0 to exit.");
                }
                Console.WriteLine(mainStack.ToString());
            } while (choice != 0);
        }
    }
}
