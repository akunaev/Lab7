//Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

static void CalcCube(double edgeLength, out double S, out double V)
{
    S = 6 * edgeLength * edgeLength;
    V = edgeLength * edgeLength * edgeLength;
}


double area, volume;

double edge = Convert.ToDouble(Console.ReadLine());
CalcCube(edge, out area, out volume);
Console.WriteLine("Площадь поверхности куба с ребром, равным {0}, равна {1:f2}.\nЕго объем равен {2:f2}", edge, area, volume);
Console.ReadKey();  
