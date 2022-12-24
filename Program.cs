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

// void FillArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(-10, 10);
//     }
// }
// void CheckOddIndArrayAndSumNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (i % 2 != 0)
//         {
//             sum = sum + array[i];
//         }
//     }
//     Console.WriteLine(sum);

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
// //Для себя, чтобы посмотреть на числа которые суммируем
// void PrintArrayWithOddInd(int[] array)
// {
//     int i = 0;
//     while (i < array.Length)
//     {
//         if (i % 2 != 0)
//         {
//             Console.Write(array[i] + " ");
//         }
//         i++;
//     }
// }
// Console.WriteLine("Сколько цифр в массиве должно быть? ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// FillArray(arr);
// PrintArray(arr);
// CheckOddIndArrayAndSumNumbers(arr);
// PrintArrayWithOddInd(arr);

// void FillArray(double[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(1,99) + rnd.NextDouble();
//     }
// }
// double FindMinNumInArray(double[] array)
// {
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (min > array[i])
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }
// double FindMaxNumInArray(double[] array)
// {
//     double max = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (max < array[i])
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }
// void PrintArray(double[] array) //Для себя, чтобы посмотреть весь массив
// {
//     int i = 0;
//     while (i < array.Length)
//     {
//         Console.Write(array[i] + " ");
//         i++;
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Сколько цифр в массиве должно быть? ");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] arr = new double[a];
// FillArray(arr);
// double min = Math.Round(FindMinNumInArray(arr),3);
// double max = Math.Round(FindMaxNumInArray(arr),3);
// // PrintArray(arr);
// // Console.WriteLine($"минимальное число в массиве {min}");
// // Console.WriteLine($"максимальное число в массиве {max}");
// Console.WriteLine($"разница между {max} и {min} = {max - min}");
