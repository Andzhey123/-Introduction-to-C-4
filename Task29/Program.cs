// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] createArray()
{
    var random = new Random();
    var result = new int[8];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(1, 99);
    }
    return result;
}

void viewArr(int[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            result += arr[i] + ", ";
        }
        if (i == arr.Length - 1)
        {
            result += arr[i] + "]";
        }
    }
    Console.WriteLine(result);
}

Console.Clear();
Console.Write("\nЗадаём массив из 8 элементов: ");
int[] array = createArray();
viewArr(array);