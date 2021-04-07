using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Aula31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Treinamento - Aula30, Calculo soma, tipo double, int, concatenação, casting*/
            //Jonas Valereo - Técnico em Informática 

            //Declarando a variavel tipo int, double

            double a = 20.50;
            double b = 20.00;
            int resultado;

            /*Declarando a variavel resultado, conversão explicita de tipo 
              para outro, de double para int*/

            resultado = (int) a + (int) b;

            //imprimir saida de dados no console, método WhriteLine, concatenação

            Console.WriteLine("A soma é: " + resultado.ToString("F1", CultureInfo.InvariantCulture));


            //Declarando a variavel resultdo, Casting conversão explicita de tipo para outro

            Console.ReadKey();

            //Fim do programa


        }
    }
}
