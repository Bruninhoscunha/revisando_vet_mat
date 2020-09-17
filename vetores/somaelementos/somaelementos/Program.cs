using System;

namespace somaelementos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A;
            int[] B;
            
            N = int.Parse(Console.ReadLine());
            A = new int[N];
            B = new int[N];
            string[] s = Console.ReadLine().Split(' ');
            string[] s1 = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(s1[i]);
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write((A[i] + B[i]) + " ");
            }
        }
    }
}
