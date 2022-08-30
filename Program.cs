// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Function(int num){
//     string text = Convert.ToString(num);
//     if (text[0] == text[4] & text[1] == text[3]){
//         Console.WriteLine("Число является палиндромом"); 
//     }

//     else{
//         Console.WriteLine("Число не является палиндромом");
//         }

//     }

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Function(number);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// double Average(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//   double a = (x2-x1)*(x2-x1);
//   double b = (y2-y1)*(y2-y1);
//   double c = (z2-z1)*(z2-z1);
//   double result = Math.Sqrt(a+b+c);
//   Console.Write("Расстояние между точкой А и В равно: " + result);
//   return result;
// }

// Console.Write("Введите координаты точки A x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки A y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки A z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки B x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки B y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты точки B z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Average(x1, y1, z1, x2, y2, z2);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Square(int n){
//     int curr = 1;
//     while(curr<=n){
//         Console.Write(curr*curr*curr + ", ");
//         curr++;
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0) Console.Write("Некорректный ввод");
// else Square(num);


//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

double Average(double x1, double y1, double x2, double y2)
{
  double a = (x2-x1)*(x2-x1);
  double b = (y2-y1)*(y2-y1);
  double result = Math.Sqrt(a+b);
  Console.Write("Расстояние между точкой А и В равно: " + result);
  return result;
}

Console.Write("Введите координаты точки A x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки A y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки B y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Average(x1, y1, x2, y2);
