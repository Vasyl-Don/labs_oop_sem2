using System;

namespace oop_9_cs
{
    class Stack
    {
        private char[] stack;
        private int count;
        const int n = 10;
        public int MaxLength { get; }
        public Stack()
        {
            stack = new char[n];
            MaxLength = n;
            count = 0;
        }
        public Stack(int length)
        {
            stack = new char[length];
            MaxLength = length;
            count = 0;
        }
        public int Count { get { return count; } }
        public static int IndexOfFirstSymbol(Stack stack, char symbol)
        {
            char[] array = stack.stack;
            int index;
            for (index = 0; index < stack.Count; index++)
            {
                if (array[index] == symbol)
                    return index + 1;
            }
            throw new Exception("No such element in stack");
        }
        public int IndexOfFirstSymbol(char symbol)
        {
            int index;
            for (index = 0; index < stack.Length; index++)
            {
                if (stack[index] == symbol)
                    return index + 1;
            }
            throw new Exception("No such element in stack");
        }
        public void Push(char symbol)
        {
            stack[count++] = symbol;
        }
        public char Pop()
        {
            if (count >= 1)
            {
                char symbol = stack[--count];
                stack[count] = default(char);
                return symbol;
            }
            else throw new Exception("The stack is empty");
        }
    }
}
