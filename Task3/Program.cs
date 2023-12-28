 {
        int[] array = { 1, 2, 3, 4, 5 }; // Произвольный массив

        PrintArrayReversed(array, array.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReversed(array, index - 1);
        }
    }