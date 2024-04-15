using System;

class Program
{
    // Função para calcular e imprimir os primeiros n números de Fibonacci
    static void FibonacciIterativo(int n)
    {
        int num1 = 0, num2 = 1, proximo;

        // Imprime os primeiros dois números de Fibonacci
        Console.Write("Sequência de Fibonacci: " + num1 + " " + num2 + " ");

        // Loop para calcular e imprimir os próximos números de Fibonacci
        for (int i = 2; i < n; i++)
        {
            proximo = num1 + num2; 
            Console.Write(proximo + " "); 
            num1 = num2; // Atualiza num1 para o próximo número na sequência
            num2 = proximo; // Atualiza num2 para o próximo número na sequência
        }
    }

    // Método Main para testar a função FibonacciIterativo
    static void Main(string[] args)
    {
        int n = 10; // Número de termos de Fibonacci a serem gerados

        FibonacciIterativo(n); 
    }
}
