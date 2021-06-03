using System;

namespace oop_9_cs
{
    public delegate void StackOverFlowEvent();
    class Program
    {
        static void EventHandler()
        {
            Console.WriteLine("\nSTACK OVERFLOW");
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            
            StackOverFlowClass stackOverFlow = new StackOverFlowClass();
            stackOverFlow.StackOverFlow += EventHandler;

            while (true)
            {
                Console.WriteLine("1 - Push an element to stack" +
                    "\n2 - Delete the last element in stack" +
                    "\n3 - Find the index of first element in stack (you need to input the element)" +
                    "\n4 - 3 but using default object" +
                    "\n0 - Exit program");
                Console.Write("Choose an action: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    char symbol;
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Input the element to push: ");
                            char element = Convert.ToChar(Console.ReadLine());
                            if (stack.Count + 1 < stack.MaxLength)
                                stack.Push(element);
                            else stackOverFlow.StackOverFlowOn();
                            break;
                        case 2:
                            Console.WriteLine($"Deleted symbol '{stack.Pop()}'");
                            break;
                        case 3:
                            Console.Write("Input the element to find: ");
                            symbol = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine($"Index of the first '{symbol}' in stack: " + stack.IndexOfFirstSymbol(symbol));
                            break;
                        case 4:
                            Console.Write("Input the element to find: ");
                            symbol = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine($"Index of the first '{symbol}' in stack: " + Stack.IndexOfFirstSymbol(stack, symbol));
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input. Try again");
                            break;
                    }
                    Console.WriteLine();
                }
                catch(Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
            }
        }
    }
}
