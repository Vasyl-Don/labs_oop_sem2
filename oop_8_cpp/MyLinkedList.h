#pragma once
#include "Node.h"
class MyLinkedList
{
private:
	Node* head;
	Node* tail;
	int count;
public:
    Node* Head();
    int Count();
    bool IsEmpty();
    void AddFirst(short value);
    bool Remove(short value);
    void Clear();
};

