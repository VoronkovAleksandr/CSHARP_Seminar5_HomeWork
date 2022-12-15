// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumOfElements(int[] checkedArray)
{
    int result = 0;
    int len = checkedArray.Length;
    for (int i=0; i<len; i++)
    {
        if ((i%2) != 0) result += checkedArray[i];
    }
    return result;
}

void ArrayOutput(int[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

int[] ArrayEntry(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
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
int[] myArray = new int[number];
myArray = ArrayEntry(myArray, -99, 100);

int sum = SumOfElements(myArray);
Console.WriteLine("Сумма четных элементов в массиве:");
ArrayOutput (myArray);
Console.WriteLine($"равна {sum}");
