/*
Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] InitArray()
{
    int[] result = new int[4];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-100, 100);
    }
    return result;
}



void PrintArray (int []arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
       Console.Write($"{arr[i]} ");
       if (i == arr.Length-1)
       Console.Write(']'); 
    }
     Console.WriteLine();
}


int GetSummOfNegatives (int[]arr)
{
    int sumResult = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
       sumResult = sumResult + arr[i];
    } 
    return sumResult;
}




int [] arr = InitArray();
PrintArray (arr);
int SummOfNegatives = GetSummOfNegatives (arr);
Console.WriteLine ($"Cумму элементов, стоящих на нечётных позициях = {SummOfNegatives}"); 