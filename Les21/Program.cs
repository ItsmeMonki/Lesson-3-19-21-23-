// Задача 21 Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//d = v((хА –  хВ)2 + (уА – уВ)2 +(zA-zb)2),

Console.Write("Введите точку X1 : ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку Y1 : ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку Z1 : ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку X2 : ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку Y2 : ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите точку Z2 : ");
double zB = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow(zA - zB, 2));

Console.WriteLine("Растояние между координатами в 3D");
Console.WriteLine($"X1={xA}, Y1={yA}, Z1={zA} и X2={xB}, Y2={yB}, Z2{zB} ---> {d}");