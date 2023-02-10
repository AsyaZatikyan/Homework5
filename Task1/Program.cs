/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] InitArray()
{
    int[] result = new int [4];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
   return result;
   }



void PrintArray(int[] arr)
{   
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        if (i == arr.Length-1)
        {
           Console.Write(']'); 
        }
    }
    Console.WriteLine();
}

int GetCountOfEvenNumbers(int[]arr)
{
    int evencountresult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2 == 0 )
        {
           evencountresult ++;       
        }
        
    }
    return evencountresult;
}

int [] arr = InitArray();
PrintArray (arr);
int count = GetCountOfEvenNumbers(arr);
Console.WriteLine($" количество чётных чисел в массиве= {count}"); 