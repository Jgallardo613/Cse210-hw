using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        
        f3.SetTop(6);
        f3.SetBottom(8);

        Console.WriteLine($"\nNew top value: {f3.GetTop()}");
        Console.WriteLine($"New bottom value: {f3.GetBottom()}");
        Console.WriteLine($"New fraction string: {f3.GetFractionString()}");
        Console.WriteLine($"New decimal value: {f3.GetDecimalValue()}");
    }
}