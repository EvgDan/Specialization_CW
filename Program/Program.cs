// Решение контрольной задачи
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

Console.WriteLine("Исходный массив данных: 12, 1567, -2, computer science");
string ish = "12, 1567, -2, computer science";
string [] parts = ish.Split(", ");
string [] result = new string [ish.Length];
int q = 0;

    for (int n = 0; n < parts.Length; n++)
    {
        if (parts[n].Length <=3) 
        {
            result[q] = parts[n] + ", ";
            q ++;
        }
    }

Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");

for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i]);
    }
