using System;

class MergeSort
{
    // Função para mesclar duas sublistas ordenadas
    void Merge(int[] arr, int left, int mid, int right)
    {
        // Tamanhos das duas sublistas a serem mescladas
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Arrays temporários para armazenar as sublistas
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Copia os dados para os arrays temporários
        for (int i = 0; i < n1; ++i)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; ++j)
            R[j] = arr[mid + 1 + j];

        // Índices iniciais dos subarrays
        int i1 = 0, i2 = 0;

        // Índice inicial da sublista mesclada
        int k = left;

        // Mescla as duas sublistas
        while (i1 < n1 && i2 < n2)
        {
            if (L[i1] <= R[i2])
            {
                arr[k] = L[i1];
                i1++;
            }
            else
            {
                arr[k] = R[i2];
                i2++;
            }
            k++;
        }

        // Copia os elementos restantes de L[] se houver algum
        while (i1 < n1)
        {
            arr[k] = L[i1];
            i1++;
            k++;
        }

        // Copia os elementos restantes de R[] se houver algum
        while (i2 < n2)
        {
            arr[k] = R[i2];
            i2++;
            k++;
        }
    }

    // Função principal que implementa o algoritmo de Merge Sort
    void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Encontra o ponto médio para dividir a lista em duas sublistas
            int mid = left + (right - left) / 2;

            // Ordena a primeira e a segunda metade
            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);

            // Mescla as duas metades ordenadas
            Merge(arr, left, mid, right);
        }
    }

    // Função para imprimir o array
    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    // Método Main para testar o algoritmo
    public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("Array original:");
        PrintArray(arr);

        MergeSort mergeSort = new MergeSort();
        mergeSort.Sort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nArray ordenado:");
        PrintArray(arr);
    }
}
