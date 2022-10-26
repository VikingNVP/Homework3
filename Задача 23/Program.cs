//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  3 -> 1, 8, 27
//  5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] result = GetTableCub(a);
int[] GetTableCub(int a)
{
    int[] array = new int [a];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}
PrintArray(result);
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
