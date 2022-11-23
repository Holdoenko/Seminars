//Задача №8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число Num: ");
int Num = Convert.ToInt32(Console.ReadLine());
int StartNum = 1;
while (StartNum <= Num)
    {
        if (StartNum % 2 == 0)
        Console.Write("{0}, ",StartNum);
        StartNum = StartNum + 1;
    }