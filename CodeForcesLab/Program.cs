
using System;

namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (!CheckDistinctDigits(++number)) ;
            Console.WriteLine(number);
        }
        private static bool CheckDistinctDigits(int number)
        {
            int temp = number;
            bool[] arr = new bool[10];
            while (temp != 0)
            {
                if (arr[temp % 10])
                    return false;
                else
                    arr[temp % 10] = true;
                temp /= 10;
            }
            return true;
        }
    }
}