using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stack_Queue
{
    public class LinkedList
    {
        public Node head;
        public Node tail;
        public void Create()
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            int a = list.Search(30);
            list.InsertAt(a + 1, 40);
            list.Display();
        }

        public Node InsertAt(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head= newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;

                    }
                    head=head.next;

                }
                if (position != 1)
                    Console.WriteLine("Position is out o range");

            }
            return head;
           
        }

        public int Search(int value)
        {
            Node temp = head;
            int count = 0;

            while (temp != null)
            {

                if (temp.data == value)
                {
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return count;
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;

            }
        }

        public void Add(int data    )
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
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

            Console.WriteLine("{0} is added into Linked List", node.data);

        }

    }
}
