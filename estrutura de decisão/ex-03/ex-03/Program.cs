using System;

class Program
{
    public static void Main(string[] args)
    {
        double h, hom, mul;
        Console.Write("qual a sua altura: ");
        h = double.Parse(Console.ReadLine());
        Console.Write("qual é o seu sexo: ");
        string s = (Console.ReadLine());
        string ho = "homem";
        if (s == ho)
        {
            hom = (72.7 * h) - 58;
            Console.Write("seu peso ideal é de: {0:F2} ", hom);
        }
        else if (s == "mulher")
        {
            mul = (62.1 * h) - 44.7;
            Console.Write("O seu peso ideal é de: {0:F2}", mul);
        }
        else
        {
            Console.Write("resposta invalida");
        }

    }
}
