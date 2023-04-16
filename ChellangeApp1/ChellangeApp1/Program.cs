using System;

namespace CountDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 67895439334780;
            int[] counts = new int[10];

            while (number > 0)
            {
                int digit = (int)(number % 10);
                counts[digit]++;
                number /= 10;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine($"Cyfra {i} występuje w liczbie {counts[i]} razy.");
            }

            Console.ReadLine();
        }
    }
}
