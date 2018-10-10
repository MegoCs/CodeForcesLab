
using System;

namespace CodeForcesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int Forces = int.Parse(Console.ReadLine());
            ObjectForces obj = new ObjectForces();
            for (int i = 0; i < Forces; i++)
            {
                string strLine = Console.ReadLine();
                var vectorNums = strLine.Split(' ');
                obj.XForce += double.Parse(vectorNums[0]);
                obj.YForce += double.Parse(vectorNums[1]);
                obj.ZForce += double.Parse(vectorNums[2]);
            }
            if (obj.XForce == 0 && obj.YForce == 0 && obj.ZForce == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        class ObjectForces
        {
            public double XForce { get; set; }
            public double YForce { get; set; }
            public double ZForce { get; set; }
        }
    }
}