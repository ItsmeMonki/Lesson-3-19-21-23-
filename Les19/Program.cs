// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5ти значное число :");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
int n = num;

if (num > 9999 && num < 100000)
{                                
    num1 = n % 10;   
    n = n / 10;       
    num2 = n % 10;    
    n = n / 10;         
    num3 = n % 10;    
    n = n / 10;       
    num4 = n % 10;    
    num5 = n / 10;    
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"{num} являеться палиндромом числа {num1}{num2}{num3}{num4}{num5}");
    }
    else 
    {
        Console.WriteLine("Не являеться палиндромом числа");
    }
}
else 
Console.WriteLine("Не пятизначное число ");