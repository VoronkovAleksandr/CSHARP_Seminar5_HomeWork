// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double differenceMinMax(double[] checkedArray)
{
    int len = checkedArray.Length;
    double min = checkedArray[0];
    double max = checkedArray[0];
    for (int i = 0; i < len; i++)
    {
        if (checkedArray[i] < min) min = checkedArray[i];
        if (checkedArray[i] > max) max = checkedArray[i];
    }
    double result = max - min;
    return result;
}

void ArrayOutput(double[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

double[] ArrayEntry(double[] array, double minValue, double maxValue)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int number = Convert.ToInt32(DataEntry("Введите длинну массива: "));
double[] myArray = new double[number];
myArray = ArrayEntry(myArray, 0, 100);

double diff = differenceMinMax(myArray);
Console.WriteLine("Разность между максимальным и минимальным элементом массива:");
ArrayOutput(myArray);
Console.WriteLine($"равна {diff}");
