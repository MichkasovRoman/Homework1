//Задача 19. Напишите программу, 
//которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

string Palindrom (int number)
{
    if (number/10000 < 1 || number/10000 >= 10)
    {
        return "Введенное вами число не является пятизначным.";
    }
    else if (number/10000 == number%10 && number%10000/1000 == number%100/10)
    {
       return "Введенное вами пятизначное число является палиндромом.";
    }
    else 
    {
        return "Введенное вами пятизначное число не является палиндромом.";
    }
}
Console.Clear();
Console.Write("Введите любое пятизначное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine (Palindrom(n));
