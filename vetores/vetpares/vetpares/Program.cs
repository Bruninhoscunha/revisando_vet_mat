using System;

namespace vetpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int cont = 0;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0) 
                {
                    Console.Write(vet[i] + " ");
                    cont++;
                }
            }
            Console.WriteLine();

            Console.WriteLine(cont);
        }
    }
}
