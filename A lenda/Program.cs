﻿/*O problema de Josephus é assim conhecido por causa da lenda de Flavius Josephus,
um historiador romano-judeu que viveu no século 1. Segundo o relato de Josephus do
cerco de Yodfat, ele e seus companheiros (40 soldados) foram presos em uma
caverna, cuja saída foi bloqueada pelos romanos. Eles preferiram suicidar-se a serem
capturados, e decidiram que iriam formar um círculo e começar a matar-se pulando de
três em três. Josephus afirma que, por sorte ou talvez pela mão de Deus, ele
permaneceu por último e preferiu entregar-se aos romanos a suicidar-se.
Entrada
Haverá NC (1 ≤ NC ≤ 30 ) casos de teste. Em cada caso de teste de entrada
haverá um par de números inteiros positivos n (1 ≤ n ≤ 10000 ) e k (1 ≤ k ≤
1000). O número n representa a quantidade de pessoas no círculo, numeradas
de 1 até n. O número k representa o tamanho do salto de um homem até o
próximo homem que será morto.
Segue um exemplo com 5 homens e um salto = 2.
Neste exemplo o elemento que restará após as eliminações é 3.
Saída
Para cada caso de teste de entrada será apresentada uma linha de saída no
seguinte formato: Caso n: m tendo sempre um espaço antes do n e do m.
*/


using System;

namespace A_lenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerodosoldado = 1;

            Console.WriteLine("declare os suicidas(1, 2, 3, 4 etc): ");
            string[] soldados = Console.ReadLine().Split();

            Console.WriteLine("escreva o tamanho do salto: ");
            int tamanhosalto = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;) 
            { 

            int soldado = Convert.ToInt32(soldados[0]);

            }









        }
    }
}
