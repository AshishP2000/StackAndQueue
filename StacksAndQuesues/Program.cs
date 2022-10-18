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
            //UC-1 Ability to create a stack of 56->30->70
            Console.WriteLine("Welcome to Satck and Queues");

            
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            stack.Display();

            Console.ReadLine();
        }
    }
}
