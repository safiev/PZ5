namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //for (int i = 20; i < 80; i += 3)
            //{ 
            //    Console.WriteLine(i);
            //}

            // Задание 2
            //char symbol = 'з';
            //string result = "";
            //for (int i = 0; i < 6; i++)
            //{ 
            //   result += Convert.ToChar(symbol + i);
            //}
            //Console.WriteLine(result);

            // Задание 3
            int n = 6;
            int m = 8;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            // Задание 4
            //int value = 19;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % value == 0 || i % value == value)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // задание 5
            //int i = 0;
            //int j = 99;
            //int difference = 21;

            //for (; ;i++, j-- )
            //{
            //    if ( j - i == difference)
            //    {
            //        Console.WriteLine($"i = {i} \nj = {j}");
            //        break;  
            //    }
            //}
        }
    }
}
