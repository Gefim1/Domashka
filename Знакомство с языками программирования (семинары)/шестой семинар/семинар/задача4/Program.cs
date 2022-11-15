// не используя рекурсию, выведите первые N чисер Фибоначчи. Первые два числа : 0 и 1

//Если N = 5 -> 01123

int[] Function(int N)
{
    if(N==1) return new int [1] {0};
    if(N==2) return new int [2] {0,1};
    int [] array = new int [N];
    array[0] = 0;
    array[1] = 1;    
    for(int i=2;i<N;i++)
    {
        array[i] = array[i-1] + array [i-2];
    }
    return array;
}
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(",", Function(Num)));
