//Задача 19. Напишите программу, 
//которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

int NumberLen (int number) // функция, выдающая количество цифр в заданном числе
{
    int count = 0;
    while (Math.Abs(number) >= 1)
    {
        number = Math.Abs(number/10);
        count ++;
    }
    return count;
}


Console.Clear();
int N = int.Parse(Console.ReadLine()!);
int M = NumberLen(N);
Console.Write(M);
