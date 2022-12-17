using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Start Number: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter End Number: ");
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine($"The Prime Numbers From {start} To {end} Is: ");
       
        for ( ; start <= end ; start++) {
            int x = 0;
            if (start == 1 || start == 0)
            {
                continue;
            }
            for (int i = 2; i < start; i++)
            { 
             
             if ( start % i == 0)
                {
                    x = 1; 
                    break;
                }
            }
            if (x != 1 )
            {
                Console.WriteLine(start);
            }
        }
    }
}
