using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int i = 0;
            int j = 0;
            double menor = double.MaxValue;
            double maior = double.MinValue;

            Console.WriteLine("Quantidade de numeros: ");
            num = int.Parse(Console.ReadLine());
            double[] numbers = new double[num];

            for (i = 0; i < num; i++)
            {
                Console.WriteLine("Insira o numero: ");
                numbers[i] = double.Parse(Console.ReadLine());
                if (numbers[i] < menor)
                {
                    menor = numbers[i];
                }
                if (numbers[i] > maior)
                {
                    maior = numbers[i];
                }
            }
            Console.WriteLine("Numeros inseridos: ");
            for (j = 0; j < num; j++)
            {
                Console.Write(" " + numbers[j]);
            }
            Console.WriteLine("o menor numero" + menor);
            Console.WriteLine("o maior numero" + maior);
            Console.ReadKey();



        }
    }
    }

