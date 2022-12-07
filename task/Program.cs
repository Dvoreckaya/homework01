//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Clear();
Console.Write("введите number1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("введите number2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
Console.WriteLine("number1 больше number2");
}
else if (number1 < number2)
{
Console.WriteLine("number2 больше number1");
}
else
{
Console.WriteLine("number 1 равно number2");
}
