using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Larger(int a,int b,int c)
            {
                if (a > b)
                    if (a > c) return a;
                    else return c;
                else if (b > c) return b;
                else return c;
            }
            int a, b, c;
            Console.Write("a값을 입력하세요 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("a값을 입력하세요 : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("a값을 입력하세요 : ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine(Larger(a, b, c));
        }
    }
}