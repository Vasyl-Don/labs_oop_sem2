#include "Main.h"
int main()
{
	MyLinkedList mylist = MyLinkedList();
    mylist.AddFirst(1);
    mylist.AddFirst(2);
    mylist.AddFirst(3);
    mylist.AddFirst(4);
    mylist.AddFirst(6);

    cout << "Our list:" << endl;
    PrintList(mylist);
    cout << "Number of elements multiple of three: " << MultipleOfThree(mylist) << endl;

    DeleteMoreThanAverage(mylist);
    cout << "\nDeleted all elements more than average value in the list\n" << endl;

    cout << "Our list:" << endl;
    PrintList(mylist);
    cout << "Number of elements multiple of three: " << MultipleOfThree(mylist) << endl;

    cout << "Is the list empty? " << mylist.IsEmpty();
    mylist.Clear();
    cout << "Is the list empty? " << mylist.IsEmpty();

	return 0;
}

int MultipleOfThree(MyLinkedList list)
{
    // Returns number of elements multiple of three in the list
    int count = 0;
    Node* current = list.Head();
    while (current != NULL)
    {
        if (current->Value % 3 == 0)
            count++;
        current = current->Next;
    }
    return count;
}
void DeleteMoreThanAverage(MyLinkedList list)
{
    // Removes all elements more than average number from the list
    Node* current = list.Head();
    short sum = 0;
    while (current != NULL)
    {
        sum += current->Value;
        current = current->Next;
    }
    double average = sum / list.Count();
    current = list.Head();
    while (current != NULL)
    {
        if (current->Value > average)
            list.Remove(current->Value);
        current = current->Next;
    }
}
void PrintList(MyLinkedList list)
{
    Node* current = list.Head();
    while (current != NULL)
    {
        cout << current->Value << "  ";
        current = current->Next;
    }
    cout << endl;
}