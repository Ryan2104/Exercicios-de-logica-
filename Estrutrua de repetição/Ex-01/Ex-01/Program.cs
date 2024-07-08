using System;

class Program
{
    public static void Main(string[] args)
    {
        double cl;
        Console.Write("Valor da conta de luz: R$ ");
        cl = double.Parse(Console.ReadLine());
        if (cl > 50.00)
            Console.Write("você esta gastando muito");

    }
}
