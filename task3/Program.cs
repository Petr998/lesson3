// void ZeroEvenElements(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             arr[i] = 0;
//         }
//     }
// }

// void PrintArrey(int[] arr)
// {
//     foreach (int e in arr)
//     {
//         Console.Write($"{e} ");
//     }
// }

// int[] arrey = { 1, 2, 3, 4, 5 };
// ZeroEvenElements(arrey);
// PrintArrey(arrey);

// Random rnd = new Random();

// int size = 1000;
// int[] arr_int = new int[size];
// int i = 0;
// while(i < size)
// {
// arr_int[i] = rnd.Next(1, 10);
// i = i + 1;
// }

// i = 0;
// while(i < size)
// {
//     Console.Write($"{arr_int[i]} ");
//     i = i + 1;
// }

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while(i < size)
{
    Console.WriteLine("Введите элемент массива(целое число):");
    string input = Console.ReadLine();
    arr_int[i] = Convert.ToInt32(input);
    i = i + 1;
}