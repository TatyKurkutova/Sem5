// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
        array[i] += new Random().NextDouble();
        array[i] = Math.Round(array[i], 1);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine("");
}


double[] numbers = new double[5];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        max = numbers[i];
    else if (numbers[i] < min)
        min = numbers[i];
}

Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Разница между минимальным и максимальным элементами массива равна: {max - min}");