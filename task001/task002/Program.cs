//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//Console.WriteLine("введите пятизначное число");
        //    string num = Console.ReadLine();
       //     string rev = string.Concat(num.Reverse());
       //     Console.WriteLine(num == rev ? "палиндром" : "не палиндром");

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Console.WriteLine("Введите координату по Х для первой точки: ");
//double x1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Y для первой точки: ");
//double y1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Х для второй точки: ");
//double z1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Y для второй точки: ");
//double x2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Y для третьей точки: ");
//double y2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Y для третьей точки: ");
//double z2 = double.Parse(Console.ReadLine());

//double distance = Math.Sqrt((x1 - x2) + (y1 - y2) + (z1 - z2));
//Console.WriteLine($"расстояние между точками {distance}");

//Задача 23: * Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=number; i++){
    Console.WriteLine(i*i*i);
}