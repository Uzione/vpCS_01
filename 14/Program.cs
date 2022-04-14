using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("정수 하나를 입력하세요 : ");
            n = int.Parse(Console.ReadLine());

            int Factorial(int n)
            {
                if (n == 1)
                    return 1;
                return Factorial(n-1)*n;
            }
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + "! = " + Factorial(i));
            }
        }
    }
}
