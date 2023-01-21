using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



Console.WriteLine("Введите размер матрици");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mass1 = new int[n, n];
int[,] mass2 = new int[n, n];
int[,] mass3 = new int[n, n];
WriteMat(mass1);
WriteMat(mass2);
Console.WriteLine();
Console.WriteLine("Матрица 1");
ReadMat(mass1);
Console.WriteLine("Матрица 2");
ReadMat(mass2);
Umn(mass1, mass2, mass3);
Console.WriteLine("Умножение матрици 1 на матрицу 2");
ReadMat(mass3);



// Ввод матрицы с клавиатуры
void WriteMat(int[,] mass)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
            mass[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

// Вывод матрицы с клавиатуры
void ReadMat(int[,] mass)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


// Умножение матрицы А на матрицу Б
void Umn(int [,] mass1, int[,] mass2, int[,] mass3)
{
    for (int i = 0; i < mass1.GetLength(0); i++)
        for (int j = 0; j < mass1.GetLength(1); j++)
            for (int k = 0; k < mass1.GetLength(0); k++)
                mass3[i, j] += mass1[i, k] * mass2[k, j];

}

// namespace ConsoleApplication1
// {
//     class Matrix
//     {
//         // Скрытые поля
//         private int n;
//         private int[,] mass;

//         // Создаем конструкторы матрицы
//         public Matrix() { }
//         public int N
//         {
//             get { return n; }
//             set { if (value > 0) n = value; }
//         }

//         // Задаем аксессоры для работы с полями вне класса Matrix
//         public Matrix(int n)
//         {
//             this.n = n;
//             mass = new int[this.n, this.n];
//         }
//         public int this[int i, int j]
//         {
//             get
//             {
//                 return mass[i, j];
//             }
//             set
//             {
//                 mass[i, j] = value;
//             }
//         }

//         // Ввод матрицы с клавиатуры
//         public void WriteMat()
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
//                     mass[i, j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
//         }

//         // Вывод матрицы с клавиатуры
//         public void ReadMat()
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write(mass[i, j] + "\t");
//                 }
//                 Console.WriteLine();
//             }
//         }

//         // Умножение матрицы А на число
//         public static Matrix umnch(Matrix a, int ch)
//         {
//             Matrix resMass = new Matrix(a.N);
//             for (int i = 0; i < a.N; i++)
//             {
//                 for (int j = 0; j < a.N; j++)
//                 {
//                     resMass[i, j] = a[i, j] * ch;
//                 }
//             }
//             return resMass;
//         }

//         // Умножение матрицы А на матрицу Б
//         public static Matrix umn(Matrix a, Matrix b)
//         {
//             Matrix resMass = new Matrix(a.N);
//             for (int i = 0; i < a.N; i++)
//                 for (int j = 0; j < b.N; j++)
//                     for (int k = 0; k < b.N; k++)
//                         resMass[i, j] += a[i, k] * b[k, j];

//             return resMass;
//         }

    

//         // перегрузка оператора умножения
//         public static Matrix operator *(Matrix a, Matrix b)
//         {
//             return Matrix.umn(a, b);
//         }

//         public static Matrix operator *(Matrix a, int b)
//         {
//             return Matrix.umnch(a, b);
//         }

//     }


//     class MainProgram
//     {

//         static void Main(string[] args)
//         {
//             Console.WriteLine("Введите размерность матрицы: ");
//             int nn = Convert.ToInt32(Console.ReadLine());
//             // Инициализация
//             Matrix mass1 = new Matrix(nn);
//             Matrix mass2 = new Matrix(nn);
//             Matrix mass3 = new Matrix(nn);
//             Matrix mass4 = new Matrix(nn);
//             Matrix mass5 = new Matrix(nn);
//             Matrix mass6 = new Matrix(nn);
//             Matrix mass7 = new Matrix(nn);
//             Matrix mass8 = new Matrix(nn);
//             Console.WriteLine("ввод Матрица А: ");
//             mass1.WriteMat();
//             Console.WriteLine("Ввод Матрица B: ");
//             mass2.WriteMat();

//             Console.WriteLine("Матрица А: ");
//             mass1.ReadMat();
//             Console.WriteLine();
//             Console.WriteLine("Матрица В: ");
//             Console.WriteLine();
//             mass2.ReadMat();

//             Console.WriteLine("Умножение матриц А и Б: ");
//             mass8 = (mass1 * mass2);
//             mass8.ReadMat();

//             Console.ReadKey();
//         }
//     }
// }





