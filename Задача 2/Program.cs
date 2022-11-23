//Задача №4.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число NumA: ");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число NumB: ");
int NumB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число NumC: ");
int NumC = Convert.ToInt32(Console.ReadLine());
if (NumA > NumB)
{
    if (NumA > NumC)
    Console.WriteLine ("NumA = max");
}
else 
{
    if (NumB > NumC)
        Console.WriteLine ("NumB = max"); 
    else     
    Console.WriteLine ("NumC = max");  
    }