using System;
namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int lower = 0, upper = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 90)
                    lower++;
                else
                    upper++;
            }
            word = (lower >= upper) ? word.ToLower() : word.ToUpper();
            Console.WriteLine(word);
        }
    }
}