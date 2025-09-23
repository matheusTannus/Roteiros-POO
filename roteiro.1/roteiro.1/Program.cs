/*using System;

class Funcionario
{
   public string Cargo { get; set; }
   public string Nome { get; set; }

   public Funcionario(string cargo, string nome)
   {
       Cargo = cargo;
       Nome = nome;
   }

   public void MostrarSalario()
   {
       switch (Cargo.ToLower())
       {
           case "gerente":
               Console.WriteLine($"{Nome} - Cargo: {Cargo} -> Salário: R$10.000,00");
               break;
           case "desenvolvedor":
               Console.WriteLine($"{Nome} - Cargo: {Cargo} -> Salário: R$5.000,00");
               break;
           case "estagiário":
           case "estagiario":
               Console.WriteLine($"{Nome} - Cargo: {Cargo} -> Salário: R$100,00");
               break;
           default:
               Console.WriteLine($"{Nome} - Cargo: {Cargo} não possui salário definido.");
               break;
       }
   }
}

class Program
{
   static void Main(string[] args)
   {
       Funcionario gerente = new Funcionario("Gerente", "Carlos");
       Funcionario dev = new Funcionario("Desenvolvedor", "Ana");
       Funcionario estagiario = new Funcionario("Estagiário", "João");

       gerente.MostrarSalario();
       dev.MostrarSalario();
       estagiario.MostrarSalario();
   }
}*/

using System;

class Fantasma
{

    public string Habilidade { get; set; }
    public string Nick { get; set; }
    public string Cor { get; set; }


    public Fantasma(string habilidade, string nick, string cor)
    {
        Habilidade = habilidade;
        Nick = nick;
        Cor = cor;
    }

    public void GerarFantasma()
    {
        Console.WriteLine("Fantasma criado!");
        Console.WriteLine($"Nick: {Nick}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fantasma f1 = new Fantasma("Velocidade", "Blinky", "Vermelho");
        f1.GerarFantasma();
        f1.Mover("direita");

        Console.WriteLine();

        Fantasma f2 = new Fantasma("Invisibilidade", "Inky", "Azul");
        f2.GerarFantasma();
        f2.Mover("esquerda");
    }
}