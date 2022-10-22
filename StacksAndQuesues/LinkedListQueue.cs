using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQuesues
{
    internal class LinkedListQueue
    {
        public Node top;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                this.top = node;
            else
            {
                Node temp = top;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
        }
        public void Dequeue()
        {
            if (top == null)
                Console.WriteLine("Queue is Empty");
            else
                Console.WriteLine("{0} is Removed", top.data);
            top = top.Next;
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("\nElements in Queue: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
    }
}
