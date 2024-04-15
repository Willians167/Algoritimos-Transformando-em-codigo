using System;

class Program
{
    // Função para realizar a ordenação utilizando o algoritmo Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped; // Flag para indicar se houve alguma troca

        // Loop para percorrer a lista
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false; // Inicialmente, não houve troca nesta iteração

            // Loop para comparar e trocar elementos adjacentes
            for (int j = 0; j < n - i - 1; j++)
            {
                // Se o elemento atual for maior que o próximo elemento, troca-os
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true; // Indica que houve uma troca nesta iteração
                }
            }

            // Se não houve trocas nesta iteração, a lista já está ordenada
            if (!swapped)
                break;
        }
    }

    // Função para imprimir o array ordenado
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Método Main para testar o algoritmo
    static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine("Array original:");
        PrintArray(arr);

        BubbleSort(arr); // Chamada da função de ordenação Bubble Sort

        Console.WriteLine("Array ordenado:");
        PrintArray(arr);
    }
}
