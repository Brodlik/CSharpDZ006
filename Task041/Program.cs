// Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter). 
// Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0 7 8 -2 -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите с клавиатуры числа через пробел в одну линию: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine ($"Количество чисел больше нуля: {count}");