using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace soma_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N;
            double soma, media;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for(int i =0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();

            Console.Write("VALORES = ");
            for (int i = 0; i < N; i++) {
                Console.Write(vet[i].ToString("F1", CI) + "  ");
            }

            soma = 0;
            for (int i = 0; i < N; i++) {
                soma = soma + vet[i];
            }

            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));

            media = (double)soma / N;
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
        }
    }
}
