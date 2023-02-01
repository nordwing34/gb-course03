// Задание 1 **********************************************************************************
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
string? aStr = Console.ReadLine();
string? bStr = Console.ReadLine();

int a = Convert.ToInt32(aStr);
int b = Convert.ToInt32(bStr);
int max = 0;

if(a > b)
	max = a;
else
	max = b;

Console.Write("Максимальное число: " + max);
*/


// Задание 2 **********************************************************************************
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
// Вводим три числа
Console.WriteLine("Введите три числа");
Console.Write("Первое число: ");
string? n1Str = Console.ReadLine();
Console.Write("Второе число: ");
string? n2Str = Console.ReadLine();
Console.Write("Третье число: ");
string? n3Str = Console.ReadLine();

// Переводим полученные символы в числовую форму
int n1 = Convert.ToInt32(n1Str);
int n2 = Convert.ToInt32(n2Str);
int n3 = Convert.ToInt32(n3Str);
int max = n1;

// Сравниваем числа
if(n2 > max) {max = n2;}
if(n3 > max) {max = n3;}

// Выводим результат
// Console.Write("Максимальное число: " + max);
Console.Write($"Максимальное число: {max}");
*/


// Задание 3 **********************************************************************************
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int res = number % 2;
if(res != 0)
	Console.WriteLine("Число нечётное");
else
	Console.WriteLine("Число чётное");
*/


// Задание 4 **********************************************************************************
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
/*
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0) {
	Console.Write("Чётные числа от 1 до N: ");
	while(number > 0){
		if( (number % 2) == 0 ) Console.Write(number + " ");
		number--;
	}
} else {
	Console.WriteLine("Введите число больше нуля");
}
*/

