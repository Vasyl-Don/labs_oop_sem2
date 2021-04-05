using System;

namespace oop_4_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line_1 = new char[] { 'I', ' ', 'l', 'o', 'v', 'e', ' ', 'C', '#' };

            Line S1 = new Line();
            Line S2 = new Line(line_1);
            Line S3 = new Line(S1);

            Console.Write("S1 = ");
            Console.WriteLine(S1.GetLine());
            Console.Write("S2 = ");
            Console.WriteLine(S2.GetLine());
            Console.Write("S3 = ");
            Console.WriteLine(S3.GetLine());

            S2 = S2 - '#';
            Console.Write("\nS2 - '#' = ");
            Console.WriteLine(S2.GetLine());

            S1 = S2 + S3;
            Console.Write("\nS2 + S3 = ");
            Console.WriteLine(S1.GetLine());
        }
    }
}
