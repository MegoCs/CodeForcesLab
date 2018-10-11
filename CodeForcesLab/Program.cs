using System;
namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char [] temp;
            if (word[0] > 90)
            {
                temp = word.ToCharArray();
                temp[0] = word[0].ToString().ToUpper()[0];
                word = new string(temp);
            }
            Console.WriteLine(word);
        }
    }
}