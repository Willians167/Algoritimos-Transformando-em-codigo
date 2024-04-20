using System;

class Program
{
    
    static void FibonacciIterativo(int n)
    {
        int num1 = 0, num2 = 1, proximo;

        
        Console.Write("Sequência de Fibonacci: " + num1 + " " + num2 + " ");

        for (int i = 2; i < n; i++)
        {
            proximo = num1 + num2; 
            Console.Write(proximo + " "); 
            num1 = num2; 
            num2 = proximo; 
        }
    }

    
    static void Main(string[] args)
    {
        int n = 10; 

        FibonacciIterativo(n); 
    }
}
