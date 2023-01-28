//Console.WriteLine("Привет, мир");

// Задание 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

string aStr = Console.ReadLine();
string bStr = Console.ReadLine();

int a = Convert.ToInt32(aStr);
int b = Convert.ToInt32(bStr);
int max = 0;

if(a > b)
	max = a;
else
	max = b;

Console.Write("Максимальное число: " + max);


