using System;
using System.Globalization;

namespace mediapares
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;
            int cont = 0;
            double soma = 0;
            double media;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    soma = soma + vet[i];
                    cont++;
                }
            }
            
            media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
