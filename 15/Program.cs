using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Hanoi(int n, char f,char v,char t)
            {
                if (n == 1)
                    Console.WriteLine("{0}=>{1}", f, t);
                else
                {
                    Hanoi(n - 1, f, t, v);
                    Console.WriteLine("{0}=>{1}", f, t);
                    Hanoi(n - 1, v, t, f);
                }
            }
            Hanoi(3, 'A', 'B', 'C');
        }
    }
}
