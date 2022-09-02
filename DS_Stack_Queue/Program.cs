namespace DS_Stack_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListSack stack = new LinkedListSack();
            Queue queue = new Queue();
            Console.WriteLine("Enter the Following number for\n1.To Create Stack\n2.To Peek and Pop\n3.");

            int entry = Convert.ToInt32(Console.ReadLine());
            switch (entry)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.Peek();
                    stack.Pop();
                    stack.Display();
                    break;
                case 3:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
            }
        }
    }
}
