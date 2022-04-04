// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество чисел");
int kolvo = Convert.ToInt32(Console.ReadLine());
int j = 0;
for (int i = 1; i <= kolvo; i++)
{
    Console.WriteLine("Введите число " + i);
    int chislo = Convert.ToInt32(Console.ReadLine());
    if (chislo > 0)
    {
        j = j + 1;
    }
}
Console.WriteLine();
Console.WriteLine(j + " - Количество чисел больше нуля");

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.


Console.WriteLine("Введите количество столбцов");
int stolb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int strok = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int [stolb, strok];

for (int i = 0; i < stolb; i++)
{
    for (int j = 0; j < strok; j++)
    {
        // Почему-то так не работает, не понял -   if (i == 0 && (i == stolb-1) && (j ==0) && (j == strok-1))
        if (i == 0)
        {
            massiv[i, j] = 1;
        }
        else if (j == 0)
        {
            massiv[i, j] = 1;
        }
        else if (i == stolb-1)
        {
            massiv[i, j] = 1;
        }
        else if (j == strok-1)
        {
            massiv[i, j] = 1;
        }
        else massiv[i, j] = 0;

        Console.Write(massiv[i, j] + " ");
    }
    Console.WriteLine();
}
