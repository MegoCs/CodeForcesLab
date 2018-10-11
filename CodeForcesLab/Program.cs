
using System;

namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] MapIntValues = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                string []numsArr = Console.ReadLine().Split(' ');
                MapIntValues[i, 0] = int.Parse(numsArr[0]);
                MapIntValues[i, 1] = int.Parse(numsArr[1]);
                MapIntValues[i, 2] = int.Parse(numsArr[2]);
            }

            bool[,] LightBoard = new bool[3, 3] { {true, true, true }, { true, true, true } , { true, true, true } };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Toggle(LightBoard, i, j, MapIntValues[i,j]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MapIntValues[i, j] = (LightBoard[i, j]) ? 1 : 0;
                    Console.Write(string.Format("{0}", MapIntValues[i, j]));
                }
                Console.WriteLine();
            }
        }
        private static void Toggle(bool[,] Board, int Ith, int Jth, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Board[Ith, Jth] = !Board[Ith, Jth];
                if(Ith+1<3)
                    Board[Ith+1, Jth] = !Board[Ith+1, Jth];
                if (Jth + 1 < 3)
                    Board[Ith , Jth+1] = !Board[Ith , Jth+1];

                if (Ith - 1 >= 0)
                    Board[Ith - 1, Jth] = !Board[Ith - 1, Jth];
                if (Jth - 1 >= 0)
                    Board[Ith, Jth - 1] = !Board[Ith, Jth - 1];
            }
        }
    }
}