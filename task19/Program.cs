/*Задача 19 Напишите программу, которая принимает
 на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int i = 0;
if (number > 9999)
{
    while (number > 0)
    {
        int x = number % 10;
        i = i * 10 + x;
        number = number / 10;
    }
    if (temp == i)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели мало символов!");
}
