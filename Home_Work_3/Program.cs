/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
Console.Write("Введите число : ");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int stepen = int.Parse(Console.ReadLine());

for(int i = 1; i <= Num; i++)
{
Console.Write($"{Math.Pow(i, stepen)} ");
}