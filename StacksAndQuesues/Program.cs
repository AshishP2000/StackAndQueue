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
            //UC-3 Ability create Queue
            Console.WriteLine("Welcome to Satck and Queues");

            LinkedListQueue Queue = new LinkedListQueue();

            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(70);

            Queue.Display();
            Console.ReadLine();
        }
    }
}
