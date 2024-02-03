
namespace com.gold
{
    // void LinkedList()
    // {
    //     LinkedList myList = new LinkedList();

    //     // Insert elements into the linked list
    //     myList.Insert(3);
    //     myList.Insert(7);
    //     myList.Insert(12);
    //     myList.Insert(5);

    //     // Display the linked list
    //     Console.WriteLine("Linked List elements:");
    //     myList.Display();
    // }
    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null!;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void Display()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void RemoveDuplicates()
        {
            HashSet<int> uniqueElements = new HashSet<int>();
            Node current = head;
            Node previous = null!;

            while (current != null)
            {
                if (uniqueElements.Contains(current.Data))
                {
                    // Remove duplicate by adjusting pointers
                    previous.Next = current.Next;
                }
                else
                {
                    uniqueElements.Add(current.Data);
                    previous = current;
                }

                current = current.Next;
            }
        }
    }

    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null!;
        }
    }
}
