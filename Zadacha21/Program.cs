// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}


int A1 = InputNumber("Введите координату A1: ");
int B1 = InputNumber("Введите координату B1: ");
int C1 = InputNumber("Введите координату C1: ");

int A2 = InputNumber("Введите координату A2: ");
int B2 = InputNumber("Введите координату B2: ");
int C2 = InputNumber("Введите координату C2: ");

System.Console.WriteLine(Math.Sqrt(Math.Pow((A2-A1),2) + Math.Pow((B2-B1),2) + (Math.Pow((C2-C1),2))));
