// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите индекс строки");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int colons = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}
if (rows < 0 | rows > array.GetLength(0) - 1 | colons > array.GetLength(1) - 1)
{
    Console.WriteLine("Значение не существует");
}
else
{
    Console.WriteLine("Значение элемента массива={0}", array[rows, colons]);
}
Console.ReadLine();
