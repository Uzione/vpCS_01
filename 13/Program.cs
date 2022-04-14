using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void pyramid(int n)
            {
                for(int i = 0; i < n; i++)
                {
                    for(int j = n-i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 0; k < 2*i-1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            pyramid(100);
        }
    }
}