using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target_2_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            int proximo = 0;
            int anterior = 0;
            Console.WriteLine("Insira um valor!");
            int numero = Convert.ToInt32(Console.ReadLine());
            proximo = Convert.ToInt32(numero);

            for (int i = 0; i <= 10; i++)
            {
                if (proximo == 0)
                {
                    proximo = 1;

                }
                else
                {
                    int temp = proximo;
                    proximo = proximo + anterior;
                    anterior = temp;

                    switch (proximo)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 5:
                        case 8:
                        case 13:
                        case 21:
                        case 34:
                        case 55:
                            Console.WriteLine($"Esse numero {proximo} faz parte da sequencia de Fibonacci!");
                            break;
                        case 4:
                        case 6:
                        case 7:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                        case 31:
                        case 32:
                        case 33:
                        case 35:
                        case 36:
                        case 37:
                        case 38:
                        case 39:
                        case 40:
                        case 41:
                        case 42:
                        case 43:
                        case 44:
                        case 45:
                        case 46:
                        case 47:
                        case 48:
                        case 49:
                        case 50:
                        case 51:
                        case 52:
                        case 53:
                        case 54:
                        case 56:
                        case 57:
                        case 58:
                        case 59:
                        case 60:
                            Console.WriteLine($"Esse numero {proximo} não faz parte da sequencia de Fibonacci");
                            break;

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
