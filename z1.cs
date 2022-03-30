// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размерность");
int razm = Convert.ToInt32(Console.ReadLine());
int a = 0;
int[] mass = new int[razm];

for (int i = 0; i < razm; i++)
{
    mass[i] = new Random().Next(100, 1000);
    Console.Write(mass[i] + " ");
	if (mass[i] % 2 == 0) a++;	
}
Console.WriteLine();
Console.WriteLine(a + " - Количество чётных");

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размерность");
int razm = Convert.ToInt32(Console.ReadLine());
int a = 0;
int[] mass = new int[razm];

for (int i = 0; i < razm; i++)
{
    mass[i] = new Random().Next(1, 23);
    Console.Write(mass[i] + " ");
	if (i % 2 != 0) a = mass[i] + a;	
}
Console.WriteLine();
Console.WriteLine(a + " - Сумма чисел на чётных позициях");

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размерность");
int razm = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[razm];
int min = mass[0];
int max = mass[0];

for (int i = 0; i < razm; i++)
{
    mass[i] = new Random().Next(-15, 19);
    Console.Write(mass[i] + " ");
	if (mass[i] > max) max = mass[i];
	if (mass[i] < min) min = mass[i];
}
Console.WriteLine();
Console.WriteLine(min + " - Минимальное число");
Console.WriteLine(max + " - Максимальное число");
Console.WriteLine(max - min + " - Разница");
