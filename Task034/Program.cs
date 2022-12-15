// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CheckEvenNumbers(int[] checkedArray)
{
    int result = 0;
    int remainderOfDivision = 0;
    for (int i=0; i<checkedArray.Length; i++)
    {
        remainderOfDivision = checkedArray[i]%2;
        if (remainderOfDivision == 0) result++;
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
myArray = ArrayEntry(myArray, 100, 1000);

int checkResult = CheckEvenNumbers(myArray);
Console.WriteLine("Число четных чисел в массиве:");
ArrayOutput (myArray);
Console.WriteLine($"равно {checkResult}");
