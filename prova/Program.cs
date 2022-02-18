/*
 Entrada
A entrada contém vários casos de teste. A primeira linha de um caso de teste contém um inteiro N que
indica o número de comandos emitidos pelo sargento (1 ≤ N ≤ 1000)). A segunda linha
contém N caracteres, descrevendo a série de comandos emitidos pelo sargento. Cada comando é
representado por uma letra: 'E' (para "Esquerda, volver!") e 'D' (para "direita, volver!"). O final da entrada
é indicado por N = 0.
A entrada deve ser lida da entrada padrão.
Saída
Para cada caso de teste da entrada seu programa deve produzir uma única linha da saída, indicando a
direção para a qual o recruta deve ter sua face voltada após executar a série de comandos, considerando
que no início o recruta tem a face voltada para o norte. A linha deve conter uma letra entre 'N', 'L', 'S' e
'O', representando respectivamente as direções norte, leste, sul e oeste.
A saída deve ser escrita na saída padrão.
*/

using System;

namespace prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Direção de Volver: ");
            string direcao = Console.ReadLine();

            Console.WriteLine("Grite o comando: E: esquerda, Volver! D: direita, Volver! ");
            string comando = Console.ReadLine();

            foreach (char item in comando)
            {
                if (item == 'd')
                {
                    if (direcao == "n")
                    {
                        direcao = "l";
                    }

                    else if (direcao == "s")
                    {
                        direcao = "o";
                    }

                    else if (direcao == "o")
                    {
                        direcao = "n";
                    }

                    else if (direcao == "l")
                    {
                        direcao = "s";
                    }
                }

                else if (item == 'e')
                {
                    if (direcao == "n")
                    {
                        direcao = "o";
                    }

                    else if (direcao == "s")
                    {
                        direcao = "l";
                    }

                    else if (direcao == "o")
                    {
                        direcao = "s";
                    }

                    else if (direcao == "l")
                    {
                        direcao = "n";
                    }
                }
            }
            int vezes = comando.Split().Length;

            Console.WriteLine($"{vezes} ordens \n {comando}, Volver está virado para: {direcao}");
        }
    }
}
