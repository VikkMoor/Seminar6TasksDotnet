// Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива с помощью поэлементного копирования.
void PrintArray(int[] arrN)
{
    int len = arrN.Length;
    int pos = 0;
    while (pos < len)
    {
        Console.Write($"{arrN[pos]} ");
        pos++;
    }
}
Console.Write("Enter array elements in order separated by commas or spaces: ");
string s = Console.ReadLine();
string[] nums = s.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[] array = nums.Select(Int32.Parse).ToArray();
int[] copyarr = new int[array.Length];
for (int i = 0; i < copyarr.Length; i++) copyarr[i] = array[i];
PrintArray(copyarr);
