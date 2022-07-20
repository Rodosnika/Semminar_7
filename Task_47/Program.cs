// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, округлёнными до одного знака.
//m = 3, n = 4.
//0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задача 47");
double[,] randomArray = GetFillArray(3, 4);
PrintArray(randomArray);

double[,] GetFillArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random randomElement = new Random();
    int max = 5;
    int min = -5;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(randomElement.NextDouble()
                                        * (max - min) + min, 1);
        }
    }
    return array;
}



void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
