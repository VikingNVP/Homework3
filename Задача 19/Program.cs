// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  14212 -> нет
//  12821 -> да
//  23432 -> да

Console.Clear();
Console.WriteLine("Введите 5-значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = {a};
int[] array = new int [5];
int result1 = FindValues(x);
int result2 = FindValues(y);
int result3 = FindValues(z);
int result4 = FindValues(b);

if(result1 == result4 || result2 == result3){
    Console.WriteLine(a + " Это палиндром");
}else Console.WriteLine(a + " Это не палиндром");

int FindValues(int x, int y, int z, int b)
{
    for(int i = 0; i < array.Length; i++)
    {
        return x = array[^5];
        return y = array[^4];
        return z = array[^2];
        return b = array[^1];
       
    }
}
