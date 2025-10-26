//exercicio 1

/*using System;
using System.Data;
using System.Runtime.CompilerServices;
class Program {
    static void Main(string[] args) { 
        try
        {
            Console.Write("insira o nome o do produto ");
            string nome = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nome)){
                throw new ArgumentException("o nome do produto nao pode estar em branco ");

            }

            Console.Write("insira o preco do produto ");
            double preco = double.Parse(Console.ReadLine());
            if(preco <= 0)
            {
                throw new ArgumentException("preco tem que ser maior que 0 ");

            }
            Console.WriteLine($"produto cadastrado {nome} _ R$ {preco:F2}");

        }
        catch(FormatException)
        {
            Console.WriteLine("erro, preco deve ser um numero valido ");
        }



    }
}*/




//exercicio 2

/*using System;

class Program
{
    static void Main(string[] args)
    {
        float temperatura = ConverterTemperatura();
        Console.WriteLine($"temperatura convertida: {temperatura}°C");
    }

    static float ConverterTemperatura()
    {
        while (true)
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                string entrada = Console.ReadLine();

                float temperatura = float.Parse(entrada);

                return temperatura;
            }
            catch (FormatException)
            {
                Console.WriteLine("formato inválido. por favor, digite um número válido (ex: 25,3).");
            }
        }
    }
}*/




//exercicio 3

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        try
        {   
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Número digitado: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }
}*/




//exercicio 4

/*using System;


public class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string mensagem) : base(mensagem)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua idade: ");

        try
        {
            int idade = int.Parse(Console.ReadLine());
            VerificarIdade(idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Idade deve ser um número inteiro.");
        }
    }

    static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");
        }
        else
        {
            Console.WriteLine("Acesso permitido.");
        }
    }
}*/

