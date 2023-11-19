Вроде бы Зад. 39. Код для проверки существует ли треугольник с такими вводимыми тремя сторонами.

// Console.Write("Введите первую сторону треугольника: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите вторую сторону треугольника: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третью сторону треугольника: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a + b > c && a + c > b && b + c > a)
// {
//     Console.Write("Может получится треугольник");
// }
// else
// {
//     Console.Write("Треугольник не получится");
// }

int[] sidesgen()
{
Console.WriteLine("Поочередно введите 3 стороны треугольника");
int[] array= new int[3];
for (int i=0;i<3;i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
}
return array;
}
void PossibleCheck(int[] array)
{
if (array[0]+array[1]>array[2]&&array[2]+array[1]>array[0]&&array[0]+array[2]>array[1])
{
    Console.WriteLine("Треугольника с такими сторонами нет");
}
else Console.WriteLine("Есть треугольник с такими сторонами");
}

PossibleCheck(sidesgen());