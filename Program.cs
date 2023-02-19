#nullable disable

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите числа через пробел: ");
int [] Arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Console.WriteLine($"Count number > 0 = {Massiv(Arr)}");

int Massiv(int [] Arr)                        
{
	int count = 0;
	for(int i = 0; i < Arr.Length; i++)
	{
	    if(Arr[i] > 0)
        {
            count++;
        }
	}
	return count;
}


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




System.Console.Write("Задайте значение b1: ");
double b1 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение b2: ");
double b2 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение k1: ");
double k1 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение k2: ");
double k2 = int.Parse(Console.ReadLine());


double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

if ((y != k1 * x + b1) || (k1 - k2 == 0)) System.Console.WriteLine("Решений нет!");
else
{
	System.Console.WriteLine($"Координаты пересечения двух прямых, x, y: ({x}); ({y})");
}
 



//Фибоначи



int Fibonacci(int n)             // Делаем фидоначи
{
	if(n == 1 || n == 2) return 1;
	else return Fibonacci(n-1) + Fibonacci(n-2);
}




System.Console.WriteLine("Введите число n:");
PrintFibonacci(int.Parse(Console.ReadLine()));
int PrintFibonacci (int n)  //  Вывод последовательности Фибоначчи
{

  for (int i = 0; i < n; i++)
  {
    System.Console.WriteLine(Fibonacci(i));
  }
  return Fibonacci(n);
}