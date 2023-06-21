/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}


/*
Разбор домашнего задания на семинаре,добавил в качастве
примера,как еще можно было решить.

12345 -> 54321
12345 % 10 = 5
12345 / 10 = 1234
1234 % 10 = 4
5 * 10 + 4 = 54
1234 / 10 = 123
123 % 10 = 3
54 * 10 + 3 = 543
123 / 10 = 12
12 % 10 = 2
543 * 10 + 2 = 5432
12 / 10 = 1
1 % 10 = 1
5432 * 10 + 1 = 54321
*/
/*
long InputNum(string message)
{
    Console.Write(message);
    return long.Parse(Console.ReadLine()!);
}

long ReverseNum(long number)
{
    long reversedNum = 0;
    while (number != 0)
    {
        reversedNum = reversedNum * 10 + number % 10;
        number /= 10;
    }
    return reversedNum;
}

bool Palindrome(long num, long rev)
{
    return num == rev;
}

long num = InputNum("Введите число: ");
long rev = ReverseNum(num);
bool res = Palindrome(num, rev);
Console.WriteLine(res);
*/