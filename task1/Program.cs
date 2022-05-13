//Задайте двумерный массив размером mxn, заполненный случайными вещественными числами
Console.Write("Введите m: "); // Демонстрационная задача
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];



for (int i = 0; i < m; i++)
{
     
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().NextDouble()*(10-1)+1;
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}