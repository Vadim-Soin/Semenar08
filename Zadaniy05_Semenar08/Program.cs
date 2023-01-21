
Console.WriteLine("Введите целое число");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, rows];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();



void FillArray(int[,] array)
{
    int n = array.GetLength(0);
    int a = 01;
    int i = 0;
    int j = 0;
    int z = array.GetLength(0) * array.GetLength(0);

    while (a < z)
    {
        while (j < n - 1)
        {
            if (a > z) break;

            array[i, j] = a;
            a++;
            j++;
        }

        while (i < n - 1)
        {
            if (a > z) break;

            array[i, j] = a;
            a++;
            i++;
        }

        while (j > array.GetLength(0) - n)
        {
            if (a > z) break;

            array[i, j] = a;
            a++;
            j--;
        }
        n--;

        while (i > array.GetLength(0) - n)
        {
            if (a > z) break;

            array[i, j] = a;
            a++;
            i--;

        }
    }
    if (a == z) array[i, j] = a;
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
