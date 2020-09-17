using System;
using System.Globalization;
    

namespace alturasexo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            char[] sexo;
            double[] altura;
            double soma = 0.0;
            double media;
            int cont = 0;
            int contM = 0;

            N = int.Parse(Console.ReadLine());
            altura = new double[N];
            sexo = new char[N];
            
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }

            double menor = altura[0];
            for (int i = 1; i < N; i++)
            {
                if (altura[i] < menor)
                {
                    menor = altura[i];
                }
            }
            Console.WriteLine("Menor Altura: " + menor.ToString("F2", CultureInfo.InvariantCulture));

            double maior = altura[0];
            for (int i = 1; i < N; i++)
            {
                if (altura[i] > maior)
                {
                    maior = altura[i];
                }
            }
            Console.WriteLine("Maior Altura: " + maior.ToString("F2", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'F')
                {
                    soma = soma + altura[i];
                    cont++;
                }
            }

            media = soma / cont;
            Console.WriteLine("Media das alturas das mulheres: " + media.ToString("F2", CultureInfo.InvariantCulture));


            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'M') 
                {
                    contM++;
                }
            }
            Console.WriteLine("Numero de homens = " + contM);
        }
    }
}
