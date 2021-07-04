using System;

namespace DYZIO2___Dyzio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
               Console.WriteLine(IsPrime());
            }
            
            
      
        }

        static int IsPrime()
        {
            string[] range = Console.ReadLine().Split(' ');
            int min = int.Parse(range[0]);
            int max = int.Parse(range[1]);
            int counter = 0;
            bool[]  tab= new bool[max + 1];

            for (int i = 2; i * i <= max; i++)
            {
                if (tab[i] == true)
                {
                    continue;
                }
                for (int j = 2 * i; j <= max; j += i)
                {
                   
                }
            }

           
            





            return counter;

        }
    }
}
