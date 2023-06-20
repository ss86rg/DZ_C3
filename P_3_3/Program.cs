//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int ReadInt(string massege)
{
    Console.Write ($"{massege} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите положительное число > ");
int x = 1;

for(int i = 1; i <= number; i++)
{
    int result = i*i*i;
    Console.WriteLine($"{result}");
}