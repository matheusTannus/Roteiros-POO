//exercicio 1

/*using System.Collections.Generic;

using System.ComponentModel;
using System.ComponentModel.Design;

public class ListaDeCompras
{
    public static void Main(string[] args)
    {

        List<string> compras = new List<string>();

        bool continuar = true;
        while (continuar)
        {

            Console.WriteLine("Lista de compras");
            Console.WriteLine("\n1 Add ");
            Console.WriteLine("2 Remover ");
            Console.WriteLine("3 Mostrar itens lista ");
            Console.WriteLine("4 Mostrar total de intens");
            Console.WriteLine("5 sair");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Adicione o produto: ");
                string adicionarProduto = Console.ReadLine();
                compras.Add(adicionarProduto);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Remova o produto: ");
                string removerProduto = Console.ReadLine();
                if (compras.Remove(removerProduto))
                {
                    Console.WriteLine("produto removido");
                }
                else
                {
                    Console.WriteLine("Nao encontrado");
                }
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Intens da Lista: ");
                if (compras.Count == 0)
                {
                    Console.WriteLine("Lista vazia");
                }
                else
                {
                    foreach (string itens in compras)
                    {
                        Console.WriteLine($"-{itens}");
                    }
                }
            }
            else if (opcao == "4")
            {
                Console.WriteLine($"Total de itens da lista: {compras.Count}");
            }
            else if (opcao == "5")
            {
                continuar = false;

            }
            else
            {
                Console.WriteLine("Opção invalida");
            }


        }
    }
}*/




//exercicio 2

/*using System;
using System.Collections.Generic;

class CatalogoDeProdutos
{
    static void Main()
    {
        Dictionary<int, string> produtos = new Dictionary<int, string>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n CATALOGO DE PRODUTOS ");
            Console.WriteLine("1  Adicionar produto");
            Console.WriteLine("2  Buscar produto por codigo");
            Console.WriteLine("3  Listar todos os produtos");
            Console.WriteLine("4  Sair");
            Console.Write("Escolha uma opção: ");

            // Valida a opção do menu
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Digite um numero valido");
                continue;
            }

            if (opcao == 1)
            {
                Console.Write("Digite o codigo do produto: ");

                // Validação do código
                if (!int.TryParse(Console.ReadLine(), out int codigo))
                {
                    Console.WriteLine("Codigo invalido, Digite apenas numeros inteiros");
                    continue;
                }

                if (produtos.ContainsKey(codigo))
                {
                    Console.WriteLine("Esse codigo ja existe");
                    continue;
                }

                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                // Validação do nome
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("O nome do produto não pode estar vazio");
                    continue;
                }

                
                produtos.Add(codigo, nome);
                Console.WriteLine("Produto adicionado com sucesso");
            }
            else if (opcao == 2)
            {
                Console.Write("Digite o código do produto: ");
                if (!int.TryParse(Console.ReadLine(), out int codigo))
                {
                    Console.WriteLine("Codigo invalido! Digite apenas numeros inteiros");
                    continue;
                }

                if (produtos.ContainsKey(codigo))
                {
                    Console.WriteLine($"Produto: {produtos[codigo]}");
                }
                else
                {
                    Console.WriteLine("Produto nao encontrado");
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("\n Lista de produtos ");

                if (produtos.Count == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
                else
                {
                    foreach (var item in produtos)
                    {
                        Console.WriteLine($"Codigo: {item.Key} - Nome: {item.Value}");
                    }
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Saindo");
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }
        }
    }
}*/




//exercicio 3

/*using System;
using System.Collections.Generic;

class NumerosUnicos
{
    static void Main()
    {
        HashSet<int> numeros = new HashSet<int>();
        int numero = -1;

        Console.WriteLine("-NUMEROS UNICOS-");
        Console.WriteLine("Digite numeros inteiros, digite 0 para parar:");

        while (numero != 0)
        {
            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                break; 
            }

            if (numeros.Contains(numero))
            {
                Console.WriteLine("Numero ja digitado, ignorado");
            }
            else
            {
                numeros.Add(numero);
                Console.WriteLine("Numero adicionado");
            }
        }

        Console.WriteLine("\n NUMEROS UNICOS DIGITADOS");
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nenhum numero foi digitado.");
        }
        else
        {
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
}*/




//exercicio 4

/*using System;
using System.Collections.Generic;

class FilaDeAtendimento
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n FILA DE ATENDIMENTO");
            Console.WriteLine("1 - Adicionar cliente a fila");
            Console.WriteLine("2 - Atender próximo cliente");
            Console.WriteLine("3 - Ver quantos clientes estão na fila");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite o nome do cliente: ");
                string nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("O nome não pode estar vazio!");
                    continue;
                }

                fila.Enqueue(nome);
                Console.WriteLine("Cliente '" + nome + "' adicionado a fila.");
            }
            else if (opcao == 2)
            {
                if (fila.Count > 0)
                {
                    string atendido = fila.Dequeue();
                    Console.WriteLine("Cliente atendido: " + atendido);
                }
                else
                {
                    Console.WriteLine("Nenhum cliente na fila para atender.");
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Clientes na fila: " + fila.Count);

                if (fila.Count > 0)
                {
                    Console.WriteLine("Ordem de atendimento:");
                    foreach (string cliente in fila)
                    {
                        Console.WriteLine("- " + cliente);
                    }
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Saindo");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }
}*/




//exercicio 5

/*using System;
using System.Collections.Generic;

class InvertePalavra
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(palavra))
        {
            Console.WriteLine("A palavra não pode estar vazia");
            return;
        }

        Stack<char> pilha = new Stack<char>();

        // Empilha cada caractere
        foreach (char c in palavra)
        {
            pilha.Push(c);
        }

        // Desempilha para formar a palavra invertida
        string palavraInvertida = "";
        while (pilha.Count > 0)
        {
            palavraInvertida += pilha.Pop();
        }

        Console.WriteLine("Palavra invertida: " + palavraInvertida);
    }
}*/
