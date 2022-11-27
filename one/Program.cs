// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void FillArray(int[] arr1)
{
    int len1 = arr1.Length;
    int ind1 = 0;
    while (ind1 < len1)
    {
        arr1[ind1] = new Random().Next(0, 10);
        ind1++;
    }
}


void PrintArray(int[] arr2)
{
    int len2 = arr2.Length;
    int pos2 = 0;
    while (pos2 < len2)
    {
        Console.Write($"{arr2[pos2]} ");
        pos2++;
    }
}
int[] array = new int[7];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int digit = 0;
int len = array.Length;
for (int i = 0; i < len / 2; i++)
{
    digit = array[i];
    array[i] = array[len - 1 - i];
    array[len - 1 - i] = digit;
   }

PrintArray(array);