using System;

namespace TPERM2___Permutacje
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                char[] alpha = new char[] {'a', 'b' ,'c', 'd', 'e', 'f' ,'g' , 'h', 'i','j','k','l' };
             
               
                int n = int.Parse(Console.ReadLine());
                char[] str = new char[n];
               
               
                for (int j = 0; j < n; j++)
                {
                    str[j] = alpha[j];
                }
                Permute(str, 0, n);

            }
        }
        static void Permute(char[] arry, int i, int x )
        {
            int j;
            if (i == x)
            {
               
                Console.WriteLine(arry);
            }
              
          
            else
            {
                for (j = i; j < x; j++)
                {
                    
                    Swap(ref arry[i], ref arry[j]);
                    Console.WriteLine(arry[i] + " " + arry[j]);
                    Permute(arry, i + 1, x);
                    Swap(ref arry[i], ref arry[j]); 
                    
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
