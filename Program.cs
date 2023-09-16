// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i} элемент -\t");
        array[i] = int.Parse(Console.ReadLine());
    }
}
int SumNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result = result + 1;
    }
    return result;
}
Console.Write("Задайте длину массива:\t");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
FillArray(array);
Console.Write("Введите значения:\n");
System.Console.WriteLine("Количество положительных чисел в массиве: " + SumNumbers(array));
