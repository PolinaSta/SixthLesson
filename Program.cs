// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)


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

// 3.  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//      y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.