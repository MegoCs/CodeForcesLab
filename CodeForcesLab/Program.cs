
using System;

namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string Code = Console.ReadLine();

            var codeArr = Code.ToCharArray();

            string res = "";

            for (int i = 0; i < Code.Length; i++)
            {
                if (codeArr[i] == '.')
                    res += '0';
                else if (codeArr[i] == '-' && codeArr[i + 1] == '.')
                {
                    res += '1';
                    i++;
                }
                else if (codeArr[i] == '-' && codeArr[i + 1] == '-')
                {
                    res += '2';
                    i++;
                }
            }
            Console.WriteLine(res);
        }
    }
}