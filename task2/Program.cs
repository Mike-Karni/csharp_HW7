/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и 
    возвращает значение этого элемента или же указание, что такого элемента нет.*/
Console.Write("Введите количество строк m: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в строке искомого элемента : ");
int positionString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию в столбце искомого элемента : ");
int positionColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 11);
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



for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (positionColumn >= 0 && positionString >= 0 && positionString == i && positionColumn == j)
        {
            Console.WriteLine($"Искомый элемент равен = {array[positionString,positionColumn]} ");
            break;
        }
        
        else if (positionColumn >= 0 && positionString >= 0 && positionString > i || positionColumn > j)
        {
            Console.WriteLine($" элемента со строкой {positionString} и столбцом  {positionColumn} в массиве нет");
            break;
            
            
        }
        
    }
 
 Console.WriteLine();
}
//Console.WriteLine($" элемента {positionString}  {positionColumn} в массиве нет");


