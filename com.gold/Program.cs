namespace com.gold
{
    partial class Program
    {
        private static void Main(string[] args)
        {

            // LinkedList();

            LinkedList myList = new LinkedList();

            // Insert elements into the linked list
            myList.Insert(33);
            myList.Insert(77);
            myList.Insert(22);
            myList.Insert(55);
            myList.Insert(22);

            // Display the linked list
            Console.WriteLine("Linked List elements:");
            myList.Display();

            myList.RemoveDuplicates();

            // Display the linked list after removing duplicates
            Console.WriteLine("Linked List elements after removing duplicates:");
            myList.Display();
        }
    }
}