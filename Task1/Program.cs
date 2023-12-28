{
int M = 1; // Начало интервала
        int N = 10; // Конец интервала

        PrintNaturalNumbers(M, N);

        Console.ReadLine();
    }

    static void PrintNaturalNumbers(int currentNumber, int end)
    {
        if (currentNumber <= end)
        {
            Console.WriteLine(currentNumber);
            PrintNaturalNumbers(currentNumber + 1, end);
        }
    }