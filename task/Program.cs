string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};		

int MaxLength = 3;
string[] SortedArray(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= MaxLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}
void PrintArray(string[] array)
{
    if(array.Length == 0)
    {
        Console.WriteLine("[]");
    }
    for(int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1)
        {
            Console.Write("'" + array[i] + "'");
        }
        else
        {
            Console.Write("'" + array[i] + "', ");
        }
    }
}
Console.Write("Array1 = ");
PrintArray(arr1);
string[] sortedarr1 = SortedArray(arr1);
Console.WriteLine();
Console.Write("Sorted array for array1 = ");
PrintArray(sortedarr1);
Console.WriteLine();
Console.WriteLine();
Console.Write("Array2 = ");
PrintArray(arr2);
string[] sortedarr2 = SortedArray(arr2);
Console.WriteLine();
Console.Write("Sorted array for array2 = ");
PrintArray(sortedarr2);
Console.WriteLine();
Console.WriteLine();
Console.Write("Array3 = ");
PrintArray(arr3);
string[] sortedarr3 = SortedArray(arr3);
Console.WriteLine();
Console.Write("Sorted array for array3 = ");
PrintArray(sortedarr3);