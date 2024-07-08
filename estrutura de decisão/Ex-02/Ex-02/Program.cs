using System;

class Program
{
    public static void Main(string[] args)
    {
        double cl;

        Console.Write("Valor da conta de luz: ");
        cl = double.Parse(Console.ReadLine());
        if (cl > 50.00)
            Console.Write("Você esta gastando muito");
        else
            Console.Write("Seu gasto foi normal ");
    }
}
