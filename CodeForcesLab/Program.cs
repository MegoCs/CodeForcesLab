
using System;

namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            int curI = -1, curJ = -1;

            for (int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                var numsStrArr = line.Split(' ');

                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = int.Parse(numsStrArr[j]);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        curI = i;
                        curJ = j;
                    }
                }
            }
            int movesNum = 0;
            movesNum += (curI > 2) ? (curI - 2) : (2 - curI);
            movesNum += (curJ > 2) ? (curJ - 2) : (2 - curJ);
            Console.WriteLine(movesNum);
        }
    }
}