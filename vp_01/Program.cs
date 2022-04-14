using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];


            Random r = new Random();

            for (int i = 0; i < 10; i++) {
                a[i] = r.Next(100);
            }
            foreach(var x in a)
                Console.WriteLine(x);

            int high = a[0];
            int low = a[0];
            int sum = 0;
            int average = 0;
            for (int i = 0; i < 10; i++){
                if (a[i] > high)
                {
                    high = a[i];
                }
                if (a[i] < low)
                {
                    low = a[i];
                }
                sum += a[i];
            }
            average = sum / 10;
            Console.WriteLine("평균 : "+average);
            Console.WriteLine("최대 : " + high);
            Console.WriteLine("최소 : "+low);
        }
    }
}