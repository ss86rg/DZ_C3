//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int ReadInt(string massege)
{
    Console.Write ($"{massege} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int A1 = ReadInt("Введите координату A1");
int A2 = ReadInt("Введите координату A2");
int A3 = ReadInt("Введите координату A3");
int B1 = ReadInt("Введите координату B1");
int B2 = ReadInt("Введите координату A2");
int B3 = ReadInt("Введите координату B3");

double result = Math.Sqrt(Math.Pow((B1-A1),2)+ Math.Pow((B2-A2),2)+ Math.Pow((B3-A3),2));

Console.WriteLine($"Расстояние между тремя точками равно: {result}");