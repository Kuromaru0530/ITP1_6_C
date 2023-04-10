using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_6_C
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int b = 0;
            int r = 0;
            int f = 0;
            int v = 0;
            int[,,] Dorm = new int[4, 3, 10];
            
            for (int i = 0; i < n; i++)
            {
                string[] Num = Console.ReadLine().Split(' ');
                b = Convert.ToInt32(Num[0]);
                r = Convert.ToInt32(Num[1]);
                f = Convert.ToInt32(Num[2]);
                v = Convert.ToInt32(Num[3]);

                Dorm[b, r, f] = v;
            }

            for(int i = 0; i < Dorm.GetLength(1); i++)
            {
                if(i > 0)
                for(int j = 0; j < Dorm.GetLength(2); j++)
                {
                    Console.Write(Dorm[0, i, j]);
                    Console.WriteLine();
                }
            }

        }
    }
}
