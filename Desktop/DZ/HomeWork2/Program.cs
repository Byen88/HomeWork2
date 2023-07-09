// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Напишите 3-значное число");
int num = Convert.ToInt32(Console.ReadLine());
int Length = num.ToString().Length;

if (Length == 3) 
{
int result = (num / 10) % 10;

Console.WriteLine("Вторая цифра " + result);
}
else {
    Console.WriteLine("Вы не ввели 3-значное число");
}
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа.

/*
Console.WriteLine("Напишите число");
int num = Convert.ToInt32(Console.ReadLine());
int Length = num.ToString().Length;

if (Length >= 3) {
    while (num > 999)
    {
    num = num / 10;
    }   

int result = num % 10;
Console.WriteLine("Третья цифра " + result);
} else {
    Console.WriteLine("Третьей цифры нет");
}
*/


// Задача 3. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool IsWeekNum (int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}
Console.WriteLine ("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine()); 

if (num < 1 || num > 7)
    Console.WriteLine("В неделе 7 дней. Введите число от 1 до 7 ");

else 
    if (IsWeekNum(num) == true)
Console.WriteLine("Этот день является выходным");
    else 
Console.WriteLine("Этот день является рабочим");
*/