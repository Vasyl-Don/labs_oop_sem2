using System;

namespace oop_7_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression[] expressions = new Expression[2];
            try
            {
                expressions[0] = new Expression();
                expressions[1] = new Expression(1, 3, 3);
                //expressions[2] = new Expression(1, 1, 1);   // Ділення на нуль
                //expressions[3] = new Expression(0, 1, -1);  // Значення під логарифмом <= 0
                //expressions[4] = new Expression(1, 0, -1);  // Обидві помилки
                for (int i = 0; i < expressions.Length; i++)
                    Console.WriteLine($"Значення виразу {i + 1}: {expressions[i].GetResult()}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Змiнiть вхiднi данi");
            }

            try
            {
                expressions[0].Set_a(0);
                expressions[1].Set_d(12);
                for (int i = 0; i < expressions.Length; i++)
                    Console.WriteLine($"Значення виразу {i + 1}: {expressions[i].GetResult()}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Змiнiть вхiднi данi");
            }
        }
    }
}
