// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// перевернёт одномерный массив

// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SwapArray(int[] array)
// {
//     int buf = 0;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         buf = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = buf;
//     }
//     ShowArray(array);
// }

// void SwapArray1(int[] array)
// {
//     int[] arr = new int[array.Length];
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         arr[i] = array[j];
//     }
//     ShowArray(arr);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = RandomArray(size);
// ShowArray(arr);
// Console.WriteLine();
// SwapArray(arr);
// SwapArray1(arr);

// 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// bool NewNum(double x, double y, double z)
// {
//     if (x < y + z && y < x + z && z < x + y)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// double A = new Random().NextDouble();
// Console.WriteLine("{0:f5}", A);

// double B = new Random().NextDouble();
// Console.WriteLine("{0:f5}", B);

// double C = new Random().NextDouble();
// Console.WriteLine("{0:f5}", C);

// if (NewNum(A, B, C))
// {
//     Console.WriteLine("Треугольник существует");
// }
// else
// {
//     Console.WriteLine("Треугольник не существует");
// }

// ДОМАШНЕЕ ЗАДАНИЕ
// 1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int[] CreatArray(int size)
// {
//     int[] array = new int [size];
//     for(int i = 0; i<size; i++)
//     {
//         Console.Write("Ввод " + i + " Элемент: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }
// void ShowArray(int[] array) 
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// void Number(int[] array)
// {
//     int count=0;
//     for(int i = 0; i<array.Length; i++)
//     {
//         if(array[i]>0)
//         {
//          count=count+1;
//         }
//     }
// Console.WriteLine(" -> " + count);
// }

// int[] myArray = CreatArray(6);
// ShowArray(myArray);
// Number(myArray);


// 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// void Number(int num)
// {
//     int x = 0;
//     int i = 0;
//     int[] Code = new int[10];

//     while (num >= 1)
//     {
//         x = num%2;
//         Code[i] = x;
//         i++;
//         num = num/2;
//         Console.Write(x);
//     }
//     Console.WriteLine();
//     for (i = (Code.Length - 1); i >= 0; i--)
//     {
//         Console.Write(Code[i]);
//     }
// }
// Console.WriteLine("Введите число для конвертации в двоичный код: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Number(N);
