Console.WriteLine("Введіть перше число:");
if (double.TryParse(Console.ReadLine(), out double number1))
{
    Console.WriteLine("Введіть друге число:");
    if (double.TryParse(Console.ReadLine(), out double number2))
    {
        double sum = number1 + number2;
        Console.WriteLine($"Сума чисел {number1} та {number2} дорівнює: {sum}");
    }
    else
    {
        Console.WriteLine("Помилка при зчитуванні другого числа.");
    }
}
else
{
    Console.WriteLine("Помилка при зчитуванні першого числа.");
}
