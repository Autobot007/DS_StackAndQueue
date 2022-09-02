using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue
{
    public class Queue
    {
        Node head = null;

        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("{0} inserted in Queue", data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp ==null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "   ");
                temp = temp.next;
            }
        }
    }
}