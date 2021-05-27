namespace oop_8_cs
{
    class MyLinkedList
    {
        private Node head;
        private Node tail;
        private int count;
        public Node Head { get { return head; } }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void AddFirst(short value)
        {
            Node node = new Node(value);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }

        public bool Remove(short value)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }
}
