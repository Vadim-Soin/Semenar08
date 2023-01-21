
Console.WriteLine("Введите размер массива");
int rows = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[rows, rows, rows];


Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();



void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = new Random().Next(10, 100);

                // for (int x = 0; x < array.GetLength(0); x++)
                // {
                //     for (int y = 0; y < array.GetLength(1); y++)
                //         for (int z = 0; z < array.GetLength(2); z++)
                //             if (x != i && y != j && z != l)
                //                 while (array[i, j, l] == array[x, y, z])
                //                     array[i, j, l] = new Random().Next(10, 100);
            //     }
            }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
                Console.Write($"{array[i, j, l]}({i},{j},{l})\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

