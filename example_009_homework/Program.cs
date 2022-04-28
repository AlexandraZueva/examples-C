// 5.Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

double x1 = 7, x2 = 1;
double y1 = -5, y2 = -1;
double z1 = 0, z2 = 9;

void Method1()
{
    double result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
    double distance = Math.Round (result,2);
    Console.WriteLine(distance);
}
Method1();