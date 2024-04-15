using System;

class Program
{
    // Função para realizar a busca binária em um array ordenado
    static int BuscaBinaria(int[] arr, int alvo)
    {
        int esquerda = 0; // Índice inicial da sublista
        int direita = arr.Length - 1; // Índice final da sublista

        while (esquerda <= direita)
        {
            int meio = esquerda + (direita - esquerda) / 2; // Índice do elemento do meio

            // Verifica se o valor alvo está no meio
            if (arr[meio] == alvo)
                return meio;

            // Se o valor alvo for maior, ignora a metade esquerda
            if (arr[meio] < alvo)
                esquerda = meio + 1;
            // Se o valor alvo for menor, ignora a metade direita
            else
                direita = meio - 1;
        }

        // Se o valor alvo não estiver presente no array, retorna -1
        return -1;
    }

    // Método Main para testar a busca binária
    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int alvo = 10;

        int resultado = BuscaBinaria(arr, alvo);

        if (resultado != -1)
            Console.WriteLine("Elemento encontrado na posição: " + resultado);
        else
            Console.WriteLine("Elemento não encontrado no array.");
    }
}
