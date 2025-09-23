/* public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;

    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome}, {Preco}");
    }
}

class Rodar
{
    public static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.preco = -200; // Deve exibir uma mensagem de erro

    }
}*/








/*public class Carro
{
    private string Modelo = "";
    private int VelocidadeAtual;

    public string ModeloProp
    {
        get { return Modelo; }
        set { Modelo = value; }
    }

    public int VelocidadeAtualProp
    {
        get { return VelocidadeAtual; }
        set
        {
            if (value < 0)
            {
                VelocidadeAtual = 0; // usa o campo privado
            }
            else
            {
                VelocidadeAtual = value;
            }
        }
    }

    public Carro (string modelo)
    {
        ModeloProp = modelo;
        VelocidadeAtualProp = 0;
    }

    public void Acelerar(int valor)
    {
        if (valor > 0)
        {
            VelocidadeAtualProp += valor;
            Console.WriteLine($"{Modelo} acelerou para {VelocidadeAtualProp} km/h");
        }
    }

    public void Frear(int valor)
    {
        if (valor > 0)
        {
            VelocidadeAtualProp -= valor;
            if (VelocidadeAtualProp < 0)
            {
                VelocidadeAtualProp = 0;
            }
            Console.WriteLine($"{Modelo} freiou para {VelocidadeAtualProp} km/h");
        }
    }
}

class Rodar
{
    public static void Main()
    {
        Carro c = new Carro("Ferrari");
        c.Acelerar(50);
        Console.WriteLine(c.VelocidadeAtualProp); // Deve exibir 50
        c.Frear(30);
        Console.WriteLine(c.VelocidadeAtualProp); // Deve exibir 20
        c.Frear(50); // Não pode ficar negativo, deve exibir 0

        Console.ReadLine(); // mantém console aberto
    }
}*/








/*using System;

namespace Primeiro_projeto
{
    public class Elevador
    {
        private int andarAtual;
        private int totalAndares;

        // Propriedade para AndarAtual com validação
        public int AndarAtual
        {
            get { return andarAtual; }
            private set
            {
                if (value < 0)
                    andarAtual = 0;
                else if (value > totalAndares)
                    andarAtual = totalAndares;
                else
                    andarAtual = value;
            }
        }

        // Propriedade somente leitura para TotalAndares
        public int TotalAndares
        {
            get { return totalAndares; }
        }

        // Construtor
        public Elevador(int totalAndares)
        {
            if (totalAndares < 0)
                totalAndares = 0;

            this.totalAndares = totalAndares;
            andarAtual = 0; // começa no térreo
        }

        // Método para subir
        public void Subir()
        {
            AndarAtual++; // a validação da propriedade impede passar do total
        }

        // Método para descer
        public void Descer()
        {
            AndarAtual--; // a validação da propriedade impede ficar negativo
        }
    }

    class Rodar
    {
        public static void Main()
        {
            Elevador e = new Elevador(10); // 10 andares

            e.Subir();
            e.Subir();
            Console.WriteLine(e.AndarAtual); // Deve exibir 2

            e.Descer();
            Console.WriteLine(e.AndarAtual); // Deve exibir 1

            e.Descer();
            e.Descer(); // Deve continuar em 0
            Console.WriteLine(e.AndarAtual); // Deve exibir 0

            Console.ReadLine(); // Mantém console aberto
        }
    }
}*/