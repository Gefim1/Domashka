// 
bool CheckTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);


Console.WriteLine($"Треугольник со сторонами {a} {b} {c} "+(CheckTriangle(a,b,c)?"является":"не является") +" треугольником");
