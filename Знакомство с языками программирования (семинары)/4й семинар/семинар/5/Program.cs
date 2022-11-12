// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillArray()
{
    int[] a = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = rnd.Next(0, 2);
    }
    return a;
}
Console.Clear();
int [] array = FillArray();
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}


// Conosole.Write(String.Join(«,», array))

