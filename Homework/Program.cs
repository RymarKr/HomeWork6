//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите размер массива : ");
int num = int.Parse(Console.ReadLine());

int[] result = CreareArray(num);
PrintArray(result);



int[] CreareArray(int num)
{
    int count = 0;
    int[] array = new int [num];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите " + (i+1) + " число: ");
            array[i] = int.Parse(Console.ReadLine()); 
        if (array[i] > 0)
    {
        count++;
    }
        }
Console.WriteLine($"Кол-во элементов больше 0: {count}");
return array;
}


void PrintArray(int[] array)
{
Console.WriteLine("Ваш массив из " + (num) + " переменных: ");
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}