double[] tempo(string[] strings)
{
    double[] numbers = new double[strings.Length];

    for (int i = 0; i < strings.Length; i++)
    {
        numbers[i] = Convert.ToDouble(strings[i]);
    }
    return numbers;
}
int countPositive(double[] numbers)
{
    int count = 0;
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите некоторое количество(М) чисел, разделяя их пробелами");

string[] strNumbers = Console.ReadLine().Split(" ");

try
{
    double[] numbers = tempo(strNumbers);
    Console.WriteLine("Количество чисел больше 0: " + countPositive(numbers));
}
catch (Exception e)
{
    Console.WriteLine("Некорректное значение");
}