//exercicio 1 

/*using System;

class Arredondamento
{
    static void Main()
    {
        decimal[] numeros = new decimal[5];

        // Leitura dos números
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1} numero decimal: ");
            while (!decimal.TryParse(Console.ReadLine(), out numeros[i]))
            {
                Console.Write("Entrada invalida. Digite um numero decimal: ");
            }
        }

        Console.WriteLine("\nResultados do arredondamento:\n");

        // Processamento e exibição
        foreach (decimal numero in numeros)
        {
            Console.WriteLine($"Numero original: {numero}");
            Console.WriteLine($"Arredondamento padrão : {Math.Round(numero)}");
            Console.WriteLine($"Arredondamento para baixo : {Math.Floor(numero)}");
            Console.WriteLine($"Arredondamento para cima : {Math.Ceiling(numero)}");
            Console.WriteLine($"Truncamento : {Math.Truncate(numero)}");
            Console.WriteLine(new string('-', 30));
        }

        Console.WriteLine("Fim");
        Console.ReadKey();
    }
}*/




//exercicio 2

/*using System;

class Virgula
{
    static void Main()
    {
        Console.Write("Digite uma frase com espaços no início ao fim e palavras separadas por virgula : ");
        string frase = Console.ReadLine().Trim();

        string[] palavras = frase.Split(',');
        Console.WriteLine("\nFrase dividida :");
        for (int i = 0; i < palavras.Length; i++)
        {
            Console.WriteLine($"Palavra {i + 1}: \"{palavras[i].Trim()}\"");
        }

        Console.Write("\nDigite a palavra que deseja substituir: ");
        string palavraAntiga = Console.ReadLine();
        Console.Write("Digite a nova palavra: ");
        string palavraNova = Console.ReadLine();

        frase = frase.Replace(palavraAntiga, palavraNova);
        Console.WriteLine($"\nFrase após : \"{frase}\"");

        Console.Write("\nDigite uma palavra para verificar se a frase começa com ela: ");
        string verificaInicio = Console.ReadLine();
        Console.WriteLine($"A frase começa com \"{verificaInicio}\"? {frase.StartsWith(verificaInicio)}");

        Console.Write("Digite uma palavra para verificar se a frase termina com ela: ");
        string verificaFim = Console.ReadLine();
        Console.WriteLine($"A frase termina com \"{verificaFim}\"? {frase.EndsWith(verificaFim)}");

        Console.WriteLine("\nFim");
        Console.ReadKey();
    }
}*/




//exercicio 4

/*using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a data e hora do compromisso (dd/MM/yyyy HH:mm): ");
        string entrada = Console.ReadLine();

        DateTime compromisso;
        while (!DateTime.TryParseExact(entrada, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out compromisso))
        {
            Console.Write("Formato inválido. Digite novamente (dd/MM/yyyy HH:mm): ");
            entrada = Console.ReadLine();
        }

        DateTime agora = DateTime.Now;
        TimeSpan diferenca = compromisso - agora;
        int diasFaltam = (int)Math.Ceiling(diferenca.TotalDays);

        string diaSemana = compromisso.ToString("dddd", new CultureInfo("pt-BR"));
        string dataFormatada = compromisso.ToString("dd/MM/yyyy 'às' HH:mm");

        string mensagem = string.Format("Olá, {0}!\nSeu compromisso sera em {1} dias, na {2}.\nData marcada: {3}",
                                        nome, diasFaltam, diaSemana, dataFormatada);

        Console.WriteLine("\n" + mensagem);
        Console.ReadKey();
    }
}*/
