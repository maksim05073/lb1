using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть спосіб заповнення масиву: ");
        Console.WriteLine("1 - Введення з клавіатури");
        Console.WriteLine("2 - Зчитування з файлу");
        Console.WriteLine("3 - Генерація випадкових чисел");
        int choice = int.Parse(Console.ReadLine());

        int[] array;

        switch (choice)
        {
            case 1:
                array = InputFromKeyboard();
                break;
            case 2:
                array = InputFromFile();
                break;
            case 3:
                array = GenerateRandomArray(10);
                break;
            default:
                Console.WriteLine("Неправильний вибір!");
                return;
        }

        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        array = ShiftArray(array);

        Console.WriteLine("Змінений масив:");
        PrintArray(array);
    }
    static int[] InputFromKeyboard()
    {
        Console.Write("Введіть кількість елементів масиву: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        
        Console.WriteLine("Введіть елементи масиву: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
    static int[] InputFromFile()
    {
        try
        {
            using (StreamReader input = new StreamReader("input.txt"))
            {
                var list = new System.Collections.Generic.List<int>();
                string line;
                while ((line = input.ReadLine()) != null)
                {
                    list.Add(int.Parse(line));2
                }
                return list.ToArray();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка читання файлу: " + ex.Message);
            return new int[0];
        }
    }
    static int[] GenerateRandomArray(int size)
    {
        Random rnd = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rnd.Next(1, 100);
        }
        return arr;
    }
    static int[] ShiftArray(int[] arr)
    {
        int M = arr.Length;
        if (M < 4) return arr;

        int shift = M - 4;
        int[] shifted = new int[M];
        
        for (int i = 0; i < M; i++)
        {
            shifted[(i + shift) % M] = arr[i];
        }
        return shifted;
    }
    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}
