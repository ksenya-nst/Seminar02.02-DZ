// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a/10000 == a%10 && a/1000 % 10 == a%10000 / 1000)
{
    System.Console.WriteLine($"Число {a} - палиндром");
}
else{
    System.Console.WriteLine($"Число {a} - не палиндром");
}