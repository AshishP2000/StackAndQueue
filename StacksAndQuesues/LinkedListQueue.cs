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
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("\nElements in stack: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
        }
    }
}
