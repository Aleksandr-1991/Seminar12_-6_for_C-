// ДЗ. Зад. 41:  Пользователь вводит  M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// /* 
int ImputNumber(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}                  //*/

int[] ImputArray(int length)
{
    int[] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ImputNumber($"Введите {i + 1}-ое число: ");
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)  Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1]);
}

int CountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i= 0; i < array.Length; i++)  count = (array[i] > 0) ? count + 1 : count;
    return count;
}

int length = ImputNumber ("Введите кол-во чисел, которые собираетесь вводить: ");
int [] array = ImputArray (length);
WriteArray (array);
Console.Write($"Количество положительных чисел равно: {CountOfPositiveNumbers(array)}");