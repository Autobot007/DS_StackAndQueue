namespace DS_Stack_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListSack stack = new LinkedListSack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
        }
    }
}