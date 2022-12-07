// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);

int sumPositive = 0;
int sumNegative = 0;

Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0 )
    {
        sumPositive+= array[i];
    }
    else
    {
        sumNegative+=array[i];
    }
}
Console.WriteLine($"Сумма положительных = {sumPositive}, Сумма отрицательных = {sumNegative}");