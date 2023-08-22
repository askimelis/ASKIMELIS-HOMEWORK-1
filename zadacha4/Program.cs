/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/ 
Console.Write("Please enter number A: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Please enter number B: ");
int numB = int.Parse(Console.ReadLine());

Console.Write("Please enter number C: ");
int numC = int.Parse(Console.ReadLine());

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;

Console.WriteLine("The largest number is " + max);
