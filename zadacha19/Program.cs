// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Boolean IsItpalindrom(int num)
{
    int firstDigit =  num / 10000;
    int secondDigit = (num / 1000) %10;
    int fouthDigit = (num/10) %10;
    int fithDigit = num %10;
    if (firstDigit == fithDigit && secondDigit == fouthDigit) return true;
    else return false;
}
Console.Write("Введите пятизначное число ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());

if (IsItpalindrom(fiveDigitNumber)) Console.Write("да");
else Console.Write("нет");
