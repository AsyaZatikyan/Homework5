/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double [] InitArray()
{
    double [] result = new double [5];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result [i] = rnd.Next(0, 100);
    }
    return result;
}

void PrintArray(double []arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write(arr[i]+" ");
       
    }
    Console.Write(']');
    Console.WriteLine();
    }


(double,double) GetDifOfMaxAndMin (double [] arr)
{
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        {
            max = arr[i];
        }
    if (arr[i] < min)
        {
            min = arr[i];
        }
}
return (min, max);
}



double [] arr = InitArray();
PrintArray(arr);
(double min, double max) = GetDifOfMaxAndMin (arr);
Console.WriteLine ($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
