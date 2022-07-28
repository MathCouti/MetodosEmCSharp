using System;

namespace Classe2
{
    class Program
    {
        //1. Crie um programa que contenha um método para realizar o cálculo da área de um círculo. A área é definida pela fórmula A = π * R². O usuário informará o valor do raio (R). Considere π igual a 3,14.

        static void Main(string[] args)
        {
            double area;
            double raio;
           
            Console.WriteLine("Qual é o RAIO do Triangulo?");
            raio = double.Parse(Console.ReadLine());
            area = calcArea(raio);
            Console.WriteLine(area);

        }
        static double calcArea(double num) //método que calcula a área
        {
            double pi = 3.14;
            double resultarea = pi * (num*num);
            return resultarea;
        }
    }
}

