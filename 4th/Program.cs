// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void PrintArray(int[] arr)
{
    int len = arr.Length;
    int pos = 0;
    while (pos < len)
    {
        Console.Write($"{arr[pos]} ");
        pos++;
    }
    Console.WriteLine();
}
Console.Write("Enter N: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrr = new int[size];
arrr[0] = 0;
arrr[1] = arrr[2] = 1;
for (int i =3; i < arrr.Length; i++) arrr[i] = arrr[i - 1] + arrr[i - 2];
PrintArray(arrr);


