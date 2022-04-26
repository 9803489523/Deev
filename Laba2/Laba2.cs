
class Laba2
{
    static void Main(string[] args)
    {
        calculating(input());
    }

    static double input()
    {
        Console.WriteLine("Введите значение аргумента: ");
        return Convert.ToDouble(Console.ReadLine());
    }

    static void calculating(double x)
    {
        if (x <= -3&&x>=-7)
             Console.WriteLine($"y={Math.Round(x+7,2)}");
        else if (x > -3 && x <= -2)
            Console.WriteLine($"y={4}");
        else if (x > -2 && x <= 2)
            Console.WriteLine($"y={Math.Round(x * x, 2)}");
        else if(x>2&&x<=4)
            Console.WriteLine($"y={Math.Round(8-2*x)}");
        else
            Console.WriteLine("Значение не входит в область определения функции");
    }
}