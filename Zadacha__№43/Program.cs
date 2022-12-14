class Program
{
    static void Main()
    {
        Console.Write("Введите k1: ");
        double k1 = double.Parse(Console.ReadLine());
        Console.Write("Введите b1: ");
        double b1 = double.Parse(Console.ReadLine());
        Console.Write("Введите k2: ");
        double k2 = double.Parse(Console.ReadLine());
        Console.Write("Введите b2: ");
        double b2 = double.Parse(Console.ReadLine());
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * x + b2);
        Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
    }
}