Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

int count = 1;

while (count <= number)
{
    Console.Write(count*count*count);
    Console.Write(", ");
    count++;
    
}
