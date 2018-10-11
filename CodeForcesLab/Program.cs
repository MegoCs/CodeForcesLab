using System;
namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int luckyNums = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == 52 || number[i] == 55)
                    luckyNums++;
            }
            if (CheckEachDigit(luckyNums))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        private static bool CheckEachDigit(int luckyNums)
        {
            string num = luckyNums.ToString();

            for (int i = 0; i < num.Length; i++)
                if (num[i] != '4' && num[i] != '7')
                    return false;
            return true;
        }
    }
}