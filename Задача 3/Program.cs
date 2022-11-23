//Задача № 6.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число Num: ");
int Num = Convert.ToInt32(Console.ReadLine());
if (Num % 2 ==0)
{
    Console.WriteLine("Num - четное");
}
else
{
     Console.WriteLine("Num - нечетное");
}