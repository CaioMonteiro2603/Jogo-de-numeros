using System;

namespace JogoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontuacao = 0;

            Console.WriteLine("Quanto é 20 * 500?\nEscreva abaixo sua resposta:");
            int resposta1 = Convert.ToInt32(Console.ReadLine());
            
            if (resposta1 == 10000)
            {
                pontuacao++;
            }

            Console.WriteLine("Dê a raiz quadrada de 16!\nEscreva abaixo sua resposta:");
            int resposta2 = Convert.ToInt32(Console.ReadLine());

            if (resposta2 == Math.Sqrt(16))
            {
                pontuacao++;
            }

            Console.WriteLine("Qual é o maior número entre 10, 15500, 45785, 654, 45786, 1457?\nEscreva abaixo sua resposta:");
            int resposta3 = Convert.ToInt32(Console.ReadLine());

            if (resposta3 == 45786)
            {
                pontuacao++;
            }

            Console.WriteLine("Sua pontuação foi:\n" + pontuacao);





        }
    }
}