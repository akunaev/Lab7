//Два треугольника заданы длинами своих сторон.
//Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).
//Для решения задачи можно использовать формулу Герона 


static double TriangleArea(double x, double y, double z)
{
    double p = (x + y + z) / 2;
    return Math.Sqrt(p*(p-x)*(p-y)*(p-z));
}

double a1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
double c1 = Convert.ToDouble(Console.ReadLine());
double a2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double c2 = Convert.ToDouble(Console.ReadLine());

if (TriangleArea(a1, b1, c1) > TriangleArea(a2, b2, c2))
{
    Console.WriteLine("Площадь первого треугольника больше");
}
else
{
    Console.WriteLine("Площадь второго треугольника больше");
}
Console.ReadKey();