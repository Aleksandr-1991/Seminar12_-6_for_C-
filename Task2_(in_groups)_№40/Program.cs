// Зад. 40: Прога приним три числа и проверяет существует ли треугольник с такими сторонами.
// "Теория неравенства треугольника": любая сторона треугольника всегда меньше суммы длин других сторон.
int[] AdoptionNumbers ()
{
    int[] array = new int[3];
    Console.WriteLine("Введите все три стороны треугольника попеременно: ");
    for (int i = 0; i < 3; i++)
    {
        array[i] = int.Parse(Console.ReadLine());   //new Random().Next(100);
    }
    return array;
}
string ValidationOfTriangle (int [] array)
{
    int absArray0 = array[0] > 0 ? array[0] : -array[0];
    int absArray1 = array[1] > 0 ? array[1] : -array[1];
    int absArray2 = array[2] > 0 ? array[2] : -array[2];

    if (absArray0 < absArray1 + absArray2 && absArray1 < absArray2 + absArray0 && absArray2 < absArray0 + absArray1)
    {
        return $"Треугольник со сторонами {array[0]}, {array[1]} и {array[2]} существует.";
    }
    else return $"Треугольник со сторонами {array[0]}, {array[1]} и {array[2]} не существует.";
}
int[] array = AdoptionNumbers();
Console.Write (ValidationOfTriangle (array));