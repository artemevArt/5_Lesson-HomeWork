// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(100, 999);
//     }
// }
// void HowManyEvenNumArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine(count);
// }
// void PrintArray(int[] array) //Для себя, чтобы посмотреть весь массив
// {
//     int i = 0;
//     while (i < array.Length)
//     {
//         Console.Write(array[i] + " ");
//         i++;
//     }
//     Console.WriteLine();
// }
// void PrintNumWithEvenIn(int[] array)//Для себя, чтобы посмотреть на четные числа
// {
//     int i = 0;
//     while (i < array.Length)
//     {
//         if (array[i] % 2 == 0)
//         {
//             Console.Write(array[i] + " ");
//         }
//         i++;
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Сколько цифр в массиве должно быть? ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// FillArray(arr);
// PrintArray(arr);
// HowManyEvenNumArray(arr);
// PrintNumWithEvenIn(arr);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
}
void CheckOddIndArrayAndSumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine(sum);

}
void PrintArray(int[] array) //Для себя, чтобы посмотреть весь массив
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}
//Для себя, чтобы посмотреть на числа которые суммируем
void PrintArrayWithOddInd(int[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        if (i % 2 != 0)
        {
            Console.Write(array[i] + " ");
        }
        i++;
    }
}
Console.WriteLine("Сколько цифр в массиве должно быть? ");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
FillArray(arr);
PrintArray(arr);
CheckOddIndArrayAndSumNumbers(arr);
PrintArrayWithOddInd(arr);