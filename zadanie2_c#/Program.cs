using System;

namespace zadanie2
{
    public class Logic
    {
        public static int Multiply(int x, int y)
        {
            int res = 0;

            for (int i = 0; i < y; i++)
            {
                res = res + x;
            }

            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            int y = int.Parse(Console.ReadLine());

            int res = Logic.Multiply(x, y);

            Console.WriteLine("x * y = " + res);

            Console.ReadLine();
        }
    }
}
