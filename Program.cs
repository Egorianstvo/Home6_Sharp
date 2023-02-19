#nullable disable

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





System.Console.Write("Задайте значение b1: ");
double b1 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение b2: ");
double b2 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение k1: ");
double k1 = int.Parse(Console.ReadLine());

System.Console.Write("Задайте значение k2: ");
double k2 = int.Parse(Console.ReadLine());











// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов > 0: {count}");