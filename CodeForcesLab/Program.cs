
using System;

namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int chNum = 0, secNum = 0;
            string queue;
            var numssArr = Console.ReadLine();

            chNum = int.Parse(numssArr.Split(' ')[0]);
            secNum = int.Parse(numssArr.Split(' ')[1]);

            queue = Console.ReadLine();
            var quArr = queue.ToCharArray();
            for (int i = 0; i < secNum; i++)
            {
                for (int j = 0; j < chNum - 1; j++)
                {
                    if (quArr[j] == 'B' && quArr[j + 1] == 'G')
                    {
                        quArr[j] = 'G';
                        quArr[j + 1] = 'B';
                        j++;
                    }
                }
            }
            Console.WriteLine(quArr);
        }
    }
}