/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/


double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArr(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(Math.Round(array[i], 1) + "  ");
    }
    Console.Write(Math.Round(array[array.Length - 1], 1));
    Console.Write("]");
}

double MinMaxDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double diff = max - min; return diff;
}

double[] arr = CreateArrayRndDouble(7, -100.0, 100.0);
PrintArr(arr);
double result = MinMaxDiff(arr);
Console.WriteLine();
Console.WriteLine($"The difference between maximal and minimal elements of the array is {Math.Round(result, 1)}");