using System;

namespace oop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть елементiв масиву: ");
            int size = int.Parse(Console.ReadLine());

            BoolArr array = new BoolArr(size);
            Console.WriteLine($"Згенерований масив з {size} елементiв булевого типу:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Результат логiчного додавання усiх елементiв масиву: " + array.LogicAdd);
            Console.Write("Введiть iндекс елемента масиву для виведення: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Елемент з iндексом {index}: " + array[index]);

            Console.WriteLine("Роботу програми завершено.");
        }
    }
}
