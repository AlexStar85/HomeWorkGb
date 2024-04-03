// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.;
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

Random random = new Random();
void FillArrayRecursively(int[] array, int index)
{
    if (index < array.Length)
    {
        array[index] = random.Next(100);
        Console.Write(array[index] + " ");
        FillArrayRecursively(array, index + 1);
    }
}
void ReversePrint(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        ReversePrint(arr, index - 1);
    }
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] myArray = new int[size];

Console.WriteLine("Сгенерированный массив: ");
FillArrayRecursively(myArray, 0);
Console.WriteLine();
Console.WriteLine("Перевернутый массив: ");
ReversePrint(myArray, myArray.Length - 1);
Console.WriteLine();