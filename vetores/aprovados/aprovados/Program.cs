using System;
using System.Globalization;

namespace aprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string[] nome;
            double[] nota1;
            double[] nota2;
            double media = 0.0;

            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            nota1 = new double[N];
            nota2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                media = (nota1[i] + nota2[i]) / 2;
                if (media >= 6.0)
                {
                    Console.WriteLine(nome[i] + " " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
                
            }
        }
    }
}
