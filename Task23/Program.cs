// Задача 23. Напишите программу, 
//которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

string GetSet(int number)
{
    string result = "";
    for (int index = 1; index < number; index++)
    {
        result += Math.Pow(index,3).ToString() + ", ";
    }
    result += Math.Pow(number,3).ToString() + ".";
    return result;
}

Console.Clear();
Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine()!);
string set = GetSet(N);
Console.WriteLine($"Множество кубов целых чисел от 1 до {N}: {set}");
