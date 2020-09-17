using System;
using System.Globalization;


namespace marioelemento
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;
            double maior = 0.0;
            int pos = 0;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                if (maior < vet[i]) 
                {
                    maior = vet[i];
                    pos = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(pos);
        }
    }
}
