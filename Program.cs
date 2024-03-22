//@niallivmi
using System;

namespace Pgc1Aula02Ex05
{
    public class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, x1, x2;
            Console.Write("Digite o valor de a: ");
            a=float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b=float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c=float.Parse(Console.ReadLine());

            d = (b * b) - 4 * a * c; //Cálculo de delta
            x1 = (-b + d) / (2 * a); //Cálculo de x1 positivo
            x2 = (-b - d) / (2 * a); //Cálculo de x2 negativo

            Console.WriteLine("O valor de x1 é: " + x1 + "O valor de x2 é: "+ x2);
            Console.ReadKey();
        }
    }
}