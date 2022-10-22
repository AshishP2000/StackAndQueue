using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQuesues
{
    internal class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next=this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack",data);
        }

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("\n{0} is at the top of the element",this.top.data);
        }

        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("\nValue Popped is {0}",this.top.data);
            this.top = this.top.Next;
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("\nElements in stack: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp=temp.Next;
            }
        }
    }
}
