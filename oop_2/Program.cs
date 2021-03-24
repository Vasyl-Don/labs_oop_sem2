using System;
using MyLib;

namespace oop_2_alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line1 = InputLine();

            MyLine line_1 = new MyLine(line1);

            MyText text = new MyText(line_1);

            ShowText(text.GetText(), text.GetNumberOfLines());
            Console.WriteLine();
            
            Console.WriteLine("Виберiть, що потрiбно зробити з текстом:" +
                "\n1 - додати рядок до тексту" +
                "\n2 - видалити рядок з тексту" +
                "\n3 - очистити текст" +
                "\n4 - отримати довжину найкоротшого рядка" +
                "\n5 - отримати вiдсоток приголосних в текстi" +
                "\n6 - видалення зайвих пробiлiв" +
                "\n7 - видалення пробiлiв на початку та в кiнцi кожного рядка" +
                "\n8 - вивести текст на консоль" +
                "\n9 - завершити роботу програми");

            while (true)
            {
                Console.WriteLine("\nВиберiть дiю");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        char[] line = InputLine();
                        MyLine _line = new MyLine(line);
                        text.AddLine(_line);
                        break;
                    case 2:
                        Console.Write("Вкажiть номер рядка для видалення: ");
                        int line_number = int.Parse(Console.ReadLine());
                        text.DeleteLine(line_number);
                        break;
                    case 3:
                        text.ClearText();
                        break;
                    case 4:
                        Console.WriteLine("Довжина найкоротшого рядка в текстi: " + text.GetShortest());
                        break;
                    case 5:
                        Console.WriteLine("Вiдсоток приголосних в текстi: " + text.ConsonantsPercent());
                        break;
                    case 6:
                        text.ReplaceSpaces();
                        break;
                    case 7:
                        text.DeleteSpaces();
                        break;
                    case 8:
                        ShowText(text.GetText(), text.GetNumberOfLines());
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Виберiть цифру зi списку вище!");
                        break;
                }
            }
        }

        static char[] InputLine()
        {
            Console.Write("Введiть рядок: ");
            int i = 0;
            char[] line = new char[1];
            do
            {
                line[i] = Console.ReadKey().KeyChar;
                i++;
                char[] temp_line = new char[i];
                for (int j = 0; j < i; j++)
                {
                    temp_line[j] = line[j];
                }
                line = new char[i + 1];

                for (int j = 0; j < i; j++)
                {
                    line[j] = temp_line[j];
                }
            }
            while (line[i - 1] != '\r');
            Console.Write('\n');
            line[i - 1] = '\0';
            return line;
        }

        static void ShowText(char[][] text, int len)
        {
            Console.WriteLine("Наш текст:");
            for (int i = 0; i < len; i++)
            {
                int j = 0;
                while (text[i][j] != '\0')
                {
                    Console.Write(text[i][j]);
                    j++;
                }
                Console.WriteLine();
            }
        }
    }
}
