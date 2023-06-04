using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Número_Primo
{
    internal class Program
    {
        //Na matemática, um Número Primo é aquele que pode ser dividido somente por 1 (um) e por ele mesmo.
        //Por exemplo, o número 7 é primo, pois pode ser dividido apenas pelo número 1 e pelo número 7.

        //Entrada
        //A entrada contém vários casos de teste.
        //A primeira linha da entrada contém um inteiro N (1 ≤ N ≤ 100), indicando o número de casos de teste da entrada.
        //Cada uma das N linhas seguintes contém um valor inteiro X (1 < X ≤ 107), que pode ser ou não, um número primo.

        //Saída
        //Para cada caso de teste de entrada, imprima a mensagem “X eh primo” ou “X nao eh primo”,
        //de acordo com a especificação fornecida.
        static void Main(string[] args)
        {
            int divisor = 2, X = 0, resto = 1;
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
               X = int.Parse(Console.ReadLine());
               while (resto != 0 && divisor <= Math.Sqrt(X))
               {
                   resto = X % divisor;
                   divisor++;
               }
               divisor = 2;
               if(resto == 0 || X == 1)
               {
                   Console.WriteLine($"{X} nao eh primo");
               }
               else
               {
                   Console.WriteLine($"{X} eh primo");
               }
               resto = 1;
            }
            Console.ReadKey();
        }
    }
}
