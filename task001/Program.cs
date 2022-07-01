//определить точку по четвертям
//int [] point = new int [2];
//Console.WriteLine("Enter axis X");
//point [0] =  Convert.ToInt32(Console.ReadLine()); //axis 0X
//Console.WriteLine("Enter axis Y");
//point [1] = Convert.ToInt32(Console.ReadLine()); //axis 0Y
//
//if(point[0] > 0 && point[1] > 0) { // x > 0 and y > 0
//   Console.WriteLine("point is located in first quarter"); 
//}
//if(point[0] < 0 && point[1] > 0) { // x < 0 and y > 0
 //  Console.WriteLine("point is located in second quarter"); 
//}
//if(point[0] < 0 && point[1] < 0) { // x < 0 and y < 0
//   Console.WriteLine("point is located in third quarter"); 
//}
//if(point[0] > 0 && point[1] < 0) { // x > 0 and y < 0
  // Console.WriteLine("point is located in forth quarter"); 
//}

//show the range of possible axis in this quarter (x,y)
//string[] quarters = {
  //  "x > 0; y > 0", //first quarter [0]
  //  "x < 0; y > 0", //second quarter [1]
  //  "x < 0; y < 0", //third quarter [2]
 //   "x > 0; y < 0" //forth quarter [3]
//};
//Console.WriteLine("Enter quarter number");
//int quarter = Convert.ToInt32(Console.ReadLine()); //number of quarter from the user
//if (quarter >= 1 && quarter <= 4){
  //  Console.WriteLine(quarters[quarter - 1]);
//}
//else {
   // Console.WriteLine("no such quarter");
//}

//Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
//Console.WriteLine("Введите координату по Х для первой точки: ");
//double x1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Y для первой точки: ");
//double y1 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Х для первой точки: ");
//double x2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату по Y для первой точки: ");
//double y2 = double.Parse(Console.ReadLine());

//double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//Console.WriteLine($"расстояние между точками {distance}");

//напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
// 5->1.4.9.16.25
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=number; i++){
    Console.WriteLine(i*i);
}

