using System;

namespace oop_8_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList mylist = new MyLinkedList();
            mylist.AddFirst(1);
            mylist.AddFirst(2);
            mylist.AddFirst(3);
            mylist.AddFirst(4);
            mylist.AddFirst(6);

            Console.WriteLine("Our list:");
            PrintList(mylist);
            Console.WriteLine("Number of elements multiple of three: " + MultipleOfThree(mylist));

            DeleteMoreThanAverage(mylist);
            Console.WriteLine("\nDeleted all elements more than average value in the list\n");

            Console.WriteLine("Our list:");
            PrintList(mylist);
            Console.WriteLine("Number of elements multiple of three: " + MultipleOfThree(mylist));

            Console.WriteLine("Is the list empty? " + mylist.IsEmpty);
            mylist.Clear();
            Console.WriteLine("Is the list empty? " + mylist.IsEmpty);
        }
            ///<summary>
            /// Returns number of elements multiple of three in the list
            ///</summary>
        static int MultipleOfThree(MyLinkedList list)
        {
            int count = 0;
            Node current = list.Head;
            while (current != null)
            {
                if (current.Value % 3 == 0)
                    count++;
                current = current.Next;
            }
            return count;
        }
            ///<summary>
            /// Removes all elements more than average number from the list
            ///</summary>
        static void DeleteMoreThanAverage(MyLinkedList list)
        {
            Node current = list.Head;
            short sum = 0;
            while(current != null)
            {
                sum += current.Value;
                current = current.Next;
            }
            double average = sum / list.Count;
            current = list.Head;
            while (current != null)
            {
                if (current.Value > average)
                    list.Remove(current.Value);
                current = current.Next;
            }
        }
        static void PrintList(MyLinkedList list)
        {
            Node current = list.Head;
            while(current!=null)
            {
                Console.Write(current.Value + "  ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
