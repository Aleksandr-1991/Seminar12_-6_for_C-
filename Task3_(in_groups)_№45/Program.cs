//Зад. 45: Напишите программу, которая будет создавать копию заданного массива.
с помощью поэлементного копирования.

int[] GenerateArray(int lengthmas)
{
    int[] array = new int[lengthmas];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    WriteArray(array);
    return array;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}
int[] CopyArray(int[] array)
{
    int[] arraycopy=new int[array.Length];
    for(int i=0;i<array.Length;i++)
    {
        arraycopy[i]=array[i];
    }
    return arraycopy;
}

Console.WriteLine("Введите длину массива");
int n=Convert.ToInt32(Console.ReadLine());
WriteArray(CopyArray(GenerateArray(n)));