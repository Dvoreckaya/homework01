// Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("число четное");
}
else
{
  Console.WriteLine("число нечетное");  
}