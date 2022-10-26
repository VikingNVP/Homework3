//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return dis;
} 
Console.WriteLine("Введите координаты первой точки А: ");
bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
bool isParsedZA = int.TryParse(Console.ReadLine(), out int zA);

Console.WriteLine("Введите координаты второй точки B: ");
bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
bool isParsedZB = int.TryParse(Console.ReadLine(), out int zB);

if(!isParsedXA || !isParsedXB || !isParsedYA || !isParsedYB || !isParsedZA || !isParsedZB)
{
    Console.WriteLine("Введите координаты правильно! ");
    return;
}
double distanceDot = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками: {distanceDot}");
