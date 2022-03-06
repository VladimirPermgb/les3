Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int n1 = number / 10000;
int n5 = number % 10;
int n2 = (number - n1 * 10000) / 1000;
int n4 = (number % 100 - n5) / 10;

// while 