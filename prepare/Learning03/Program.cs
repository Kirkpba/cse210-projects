using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.FractionString());
        Console.WriteLine(f1.DecimalAnswer());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.FractionString());
        Console.WriteLine(f2.DecimalAnswer());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.FractionString());
        Console.WriteLine(f3.DecimalAnswer());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.FractionString());
        Console.WriteLine(f4.DecimalAnswer());
        //Yippeee!
    }
}