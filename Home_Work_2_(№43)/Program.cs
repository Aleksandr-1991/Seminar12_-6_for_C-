// ДЗ. Зад. 43.  Прога найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1,  y = k2 * x + b2.  Значения k1, b1, k2, b2 задаются пользователем.
int constantaB = 0;
int constantaK = 1;
int coordinateX = 0;
int coordinateY = 1;
int Imput(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double [] ImputParametersOfLine (int numberOfLine)
{
    double [] parametersOfLine = new double[2];
    parametersOfLine [constantaB] = Imput($"Ведите константу ''B'' для {numberOfLine}-ой прямой: ");
    parametersOfLine [constantaK] = Imput($"Ведите константу ''K'' для {numberOfLine}-ой прямой: ");
    return parametersOfLine;
}
double [] FindCoordinatesOfIntersectionPoint (double [] parametersOfLine1, double [] parametersOfLine2)
{
    double[] coordinatesOfIntersectionPoint = new double[2];
    coordinatesOfIntersectionPoint[coordinateX] = (parametersOfLine1[constantaK] - parametersOfLine2[constantaK]) / (parametersOfLine2[constantaB] - parametersOfLine1[constantaB]);
    coordinatesOfIntersectionPoint[coordinateY] = parametersOfLine1[constantaB] * coordinatesOfIntersectionPoint[coordinateX] + parametersOfLine1[constantaK];
    return coordinatesOfIntersectionPoint;
}
void CheckOfParallelism (double [] parametersOfLine1, double [] parametersOfLine2)
{
    if(parametersOfLine2[constantaB] == parametersOfLine1[constantaB])
        if(parametersOfLine2[constantaK] == parametersOfLine1[constantaK])  Console.Write("Данные прямые не только параллельны, но и полностью совпадают.");
            else  Console.Write("Данные прямые параллельны.");
    double [] coordinates = FindCoordinatesOfIntersectionPoint (parametersOfLine1, parametersOfLine2);
    Console.Write($"Координаты точки пересечения линий, заданных уравнениями: \n y = {parametersOfLine1[constantaB]} * x + {parametersOfLine1[constantaK]} и  \n y = {parametersOfLine2[constantaB]} * x + {parametersOfLine2[constantaK]} таковы: \n ({coordinates[coordinateX]}, {coordinates[coordinateY]}).");
}

double [] lineData1 = ImputParametersOfLine(1);
double [] lineData2 = ImputParametersOfLine(2);
CheckOfParallelism (lineData1, lineData2);