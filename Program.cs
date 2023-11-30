//task1
using System;

class Program
{
    static void Main()
    {
        
        Random random = new Random();

       
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

       
        Console.WriteLine("Случайно сгенерированный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        int count = 0;
        foreach (int element in array)
        {
            if (element >= 20 && element <= 90)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество элементов в диапазоне [20, 90]: {count}");
    }
}

//task 2
// using System;

// class Program
// {
//     static void Main()
//     {
       
//         Random random = new Random();

//         int[] array = new int[10];
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = random.Next(1, 101);
//         }

//         Console.WriteLine("Массив:");
//         foreach (int element in array)
//         {
//             Console.Write(element + " ");
//         }
//         Console.WriteLine();

       
//         int evenCount = 0;
//         foreach (int element in array)
//         {
//             if (element % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
//     }
// }

//task 3
// using System;

// class Program
// {
//     static void Main()
//     {
        
//         Random random = new Random();

        
//         double[] array = new double[10];
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = Math.Round(random.NextDouble() * 100, 2); 
//         }

       
//         Console.WriteLine("Массив:");
//         foreach (double element in array)
//         {
//             Console.Write(element + " ");
//         }
//         Console.WriteLine();

        
//         double max = array[0];
//         double min = array[0];

//         foreach (double element in array)
//         {
//             if (element > max)
//             {
//                 max = element;
//             }

//             if (element < min)
//             {
//                 min = element;
//             }
//         }

        
//         double difference = max - min;

       
//         Console.WriteLine($"Максимальный элемент: {max}");
//         Console.WriteLine($"Минимальный элемент: {min}");
//         Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
//     }
// }
