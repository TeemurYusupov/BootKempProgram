Console.Clear();
// заполнение
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];


for(int i = 0; i < n; i ++)
{
Console.WriteLine("Введите число:");
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join("," , array) + "]");

// сортировка
for (int i = 0; i < n - 1; i++)
{
    int MinIndex = i;
    for(int j = i+ 1; j < n; j++)
    {
        if(array[j] < array[MinIndex])
        MinIndex = j;
    }
    int temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;

}
Console.WriteLine("Конечный массив: [" + string.Join("," , array) + "]");