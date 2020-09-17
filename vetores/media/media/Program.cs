using System;
using System.Globalization;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;
            double soma = 0.0;
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
                soma = soma + vet[i];
            }

            media = soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
            {

            }
        }
    }
}
