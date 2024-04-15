using System;

// Definição da estrutura do nó da árvore
class No
{
    public int chave;
    public No esquerda, direita;

    public No(int item)
    {
        chave = item;
        esquerda = null;
        direita = null;
    }
}

// Classe da Árvore de Busca Binária
class ArvoreBuscaBinaria
{
    // Raiz da árvore
    No raiz;

    // Construtor
    public ArvoreBuscaBinaria()
    {
        raiz = null;
    }

    // Função para inserir um novo nó na árvore
    public No InserirNo(No no, int chave)
    {
        // Se a árvore estiver vazia, retorna um novo nó
        if (no == null)
        {
            no = new No(chave);
            return no;
        }

        // Caso contrário, recursivamente insere na subárvore esquerda ou direita
        if (chave < no.chave)
            no.esquerda = InserirNo(no.esquerda, chave);
        else if (chave > no.chave)
            no.direita = InserirNo(no.direita, chave);

        // Retorna o ponteiro do nó (inalterado)
        return no;
    }

    // Função para realizar a travessia em ordem da árvore (em ordem crescente)
    public void TravessiaEmOrdem(No no)
    {
        if (no != null)
        {
            TravessiaEmOrdem(no.esquerda);
            Console.Write(no.chave + " ");
            TravessiaEmOrdem(no.direita);
        }
    }

    // Método Main para testar a Árvore de Busca Binária
    public static void Main(string[] args)
    {
        ArvoreBuscaBinaria arvore = new ArvoreBuscaBinaria();

        /* Exemplo de inserção de nós */
        arvore.raiz = arvore.InserirNo(arvore.raiz, 50);
        arvore.raiz = arvore.InserirNo(arvore.raiz, 30);
        arvore.raiz = arvore.InserirNo(arvore.raiz, 20);
        arvore.raiz = arvore.InserirNo(arvore.raiz, 40);
        arvore.raiz = arvore.InserirNo(arvore.raiz, 70);
        arvore.raiz = arvore.InserirNo(arvore.raiz, 60);
        arvore.raiz = arvore.InserirNo(arvore.raiz, 80);

        /* Imprime a árvore em ordem crescente */
        Console.WriteLine("Árvore de Busca Binária em ordem crescente:");
        arvore.TravessiaEmOrdem(arvore.raiz);
    }
}
