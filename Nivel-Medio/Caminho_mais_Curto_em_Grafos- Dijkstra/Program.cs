using System;

class Dijkstra
{
    static int V = 9; // Número de vértices no grafo

    // Função auxiliar para encontrar o vértice com a menor distância no conjunto de vértices ainda não processados
    int MinDistance(int[] dist, bool[] sptSet)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    // Função para imprimir a solução construída
    void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vértice \t Distância da Origem");
        for (int i = 0; i < V; i++)
            Console.WriteLine(i + " \t\t " + dist[i]);
    }

    // Função principal que implementa o algoritmo de Dijkstra para um grafo representado usando matriz de adjacência
    void DijkstraAlgorithm(int[,] graph, int src)
    {
        int[] dist = new int[V]; // Array de distâncias mais curtas do vértice de origem para o i-ésimo vértice
        bool[] sptSet = new bool[V]; // Array para verificar se o vértice i está incluído no menor caminho ou não

        // Inicializa todas as distâncias como infinito e sptSet[] como false
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        // A distância do vértice de origem para ele mesmo é sempre 0
        dist[src] = 0;

        // Encontra o caminho mais curto para todos os vértices
        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, sptSet); // Pega o vértice com a menor distância do conjunto de vértices ainda não processados
            sptSet[u] = true; // Marca o vértice como processado

            // Atualiza a distância dos vértices adjacentes de u que ainda não estão no menor caminho
            for (int v = 0; v < V; v++)
            {
                // Atualiza dist[v] apenas se não estiver em sptSet, houver uma aresta de u para v e o peso total do caminho de origem para v passando por u for menor do que o valor atual de dist[v]
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
            }
        }

        // Imprime o array de distâncias construído
        PrintSolution(dist);
    }

    // Método Main para testar o algoritmo
    public static void Main()
    {
        // Exemplo de um grafo representado usando matriz de adjacência
        int[,] graph = new int[,] { {0, 4, 0, 0, 0, 0, 0, 8, 0},
                                     {4, 0, 8, 0, 0, 0, 0, 11, 0},
                                     {0, 8, 0, 7, 0, 4, 0, 0, 2},
                                     {0, 0, 7, 0, 9, 14, 0, 0, 0},
                                     {0, 0, 0, 9, 0, 10, 0, 0, 0},
                                     {0, 0, 4, 14, 10, 0, 2, 0, 0},
                                     {0, 0, 0, 0, 0, 2, 0, 1, 6},
                                     {8, 11, 0, 0, 0, 0, 1, 0, 7},
                                     {0, 0, 2, 0, 0, 0, 6, 7, 0} };
        
        Dijkstra djk = new Dijkstra();
        djk.DijkstraAlgorithm(graph, 0); // Encontra o caminho mais curto a partir do vértice 0
    }
}
