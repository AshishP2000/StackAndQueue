using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQuesues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Ability to peak and pop from stack till it is empty
            Console.WriteLine("Welcome to Satck and Queues");

            
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            stack.Peek();
            stack.Pop();
            stack.Display();

            Console.ReadLine();
        }
    }
}
