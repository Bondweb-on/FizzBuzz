using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            
            int i; 

            for (i = 0; i < 100; i++) 
            {
                numeros[i] = i + 1;
            }
            
            for (i = 0; i < numeros.Length; i++) 
            {
                if (numeros[i]%3 == 0 && numeros[i]%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (numeros[i]%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (numeros[i]%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
