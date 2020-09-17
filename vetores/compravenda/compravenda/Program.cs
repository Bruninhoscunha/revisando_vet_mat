using System;
using System.Globalization;

namespace compravenda
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;
            double valorTotalCompra = 0.0;
            double valorTotalVenda = 0.0;
            string[] produto;
            double[] compra;
            double[] venda;
            double lucro;
            double porcentagemDeLucro;

            N = int.Parse(Console.ReadLine());
            produto = new string[N];
            compra = new double[N];
            venda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produto[i] = s[0];
                compra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            
            for (int i = 0; i < N; i++)
            {
                lucro = venda[i] - compra[i];
                porcentagemDeLucro = lucro / compra[i] * 100.0;

                if (porcentagemDeLucro < 10.0)
                {
                    contAbaixoDe10++;
                }

                else if (porcentagemDeLucro <= 20.0)
                {
                    contEntre10E20++;
                }

                else
                {
                    contAcimaDe20++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10 % e 20 %: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            for (int i = 0; i < N; i++)
            {
                valorTotalCompra = valorTotalCompra + compra[i];
                valorTotalVenda = valorTotalVenda + venda[i];
            }

            double totalLucro = valorTotalVenda - valorTotalCompra;

            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
