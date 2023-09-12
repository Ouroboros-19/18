class Program
{
    static void Main()
    {
        Random r = new Random();
        int n = 5, m = 7;
        int[,] array = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write("{0,3}", array[i, j] = r.Next(0, 10));
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    Console.Write("{0,3}", array[i, j]);
                else
                    Console.Write("{0,3}", "");
            Console.WriteLine();
        }
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("\n\tПовторить?(enter - Да, др.кл. + enter - НЕТ)\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        string proverka = Convert.ToString(Console.ReadLine());
        if (proverka == "")
            Main();
    }
}