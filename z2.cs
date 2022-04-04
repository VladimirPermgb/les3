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


