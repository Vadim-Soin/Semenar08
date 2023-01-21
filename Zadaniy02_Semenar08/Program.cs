

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];


Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    int index = 0;
    int min = 999;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)

        {

            sum = sum + array[i, j];

            if (j == array.GetLength(1) - 1)
            {
                if (min > sum)
                {
                    min = sum;
                    index = i;
                }
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой чисел № {index + 1} с суммой {min}");
}



















