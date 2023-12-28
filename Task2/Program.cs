{
        int m = 3; // Первый параметр
        int n = 4; // Второй параметр

        int result = CalculateAckermann(m, n);
        Console.WriteLine("Результат: " + result);

        Console.ReadLine();
    }

    static int CalculateAckermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return CalculateAckermann(m - 1, 1);
        else
            return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
    }
