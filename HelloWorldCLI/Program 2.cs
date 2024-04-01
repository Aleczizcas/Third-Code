using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("Hello Goodbye ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Hello ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Goodbye ");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
    }
}