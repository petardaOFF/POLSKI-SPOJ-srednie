using System;

namespace LENLCS___Długość_najdłuższego_wspólnego_podciągu
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            for (int i = 0; i < D; i++)
            {
                Console.ReadLine();
                string s1 = Console.ReadLine();
                Console.ReadLine();
                string s2 = Console.ReadLine();
                Console.WriteLine(LCS(s1, s2));
             }
          }

        static int LCS(string s1, string s2)
        {
         int[,] c = new int[s1.Length + 1, s2.Length + 1];
           
            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
     
                    if (s1[i - 1] == s2[j - 1])
                    {
                        c[i, j] = c[i - 1, j - 1] + 1;
                    }
                     else
                    {
                        if (c[i - 1, j] > c[i, j - 1])
                        {
                            c[i, j] = c[i - 1, j];
                        }
                        else
                        {
                            c[i, j] = c[i, j - 1];
                        }
                    }
                   
                }

            }
            return c[s1.Length, s2.Length];

        }
       
    }
}
