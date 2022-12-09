// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

Console.WriteLine(string.Join(", ", array));

Console.Write("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
bool flag = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        flag = true;
        break;
    }
}

if (flag == false)
{
    Console.WriteLine("Число отсутствует.");
}
else
{
    Console.WriteLine("Число присутствует в массиве.");
}