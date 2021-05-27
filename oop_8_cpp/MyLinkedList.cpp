#include "MyLinkedList.h"
Node* MyLinkedList::Head()
{
    return head;
}
int MyLinkedList::Count()
{
    return count;
}
bool MyLinkedList::IsEmpty()
{
    return count == 0;
}

void MyLinkedList::AddFirst(short value)
{
    Node* node = new Node(value);
    node->Next = head;
    head = node;
    if (count == 0)
        tail = head;
    count++;
}

bool MyLinkedList::Remove(short value)
{
    Node* current = head;
    Node* previous = NULL;

    while (current != NULL)
    {
        if (current->Value == value)
        {
            if (previous != NULL)
            {
                previous->Next = current->Next;

                if (current->Next == NULL)
                    tail = previous;
            }
            else
            {
                head = head->Next;

                if (head == NULL)
                    tail = NULL;
            }
            count--;
            return true;
        }
        previous = current;
        current = current->Next;
    }
    return false;
}
void MyLinkedList::Clear()
{
    head = NULL;
    tail = NULL;
    count = 0;
}