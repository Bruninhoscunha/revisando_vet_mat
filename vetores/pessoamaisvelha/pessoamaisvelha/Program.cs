using System;

namespace pessoamaisvelha
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nome;
            int[] idade;

            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            idade = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
            }

            int maior = idade[0];
            for (int i = 1; i < N; i++)
            {
                if (idade[i] > maior)
                {
                    idade[i] = maior;
                }
            }

            Console.WriteLine(maior);
           
            
        }
    }
}
