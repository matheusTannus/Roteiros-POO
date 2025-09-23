/*using System;   
class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento sendo feito");
    }
}
class CartaoDeCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento no Cartao De Credito");

    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento no Boleto Bancario");
    }
}
class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento sendo feito no Pix");
    }
}
class program
{
    static void Main()
    {
        Pagamento pagamento = new CartaoDeCredito();
        pagamento.ProcessarPagamento();
        Pagamento pagamento1 = new BoletoBancario();
        pagamento1.ProcessarPagamento();
        Pagamento pagamento2 = new Pix();
        pagamento2.ProcessarPagamento();

    }
}*/






/*using System;

abstract class Funcionario
{
    public string Nome { get; set; }
    public double SalarioBase { get; set; }

    public Funcionario(string nome, double salarioBase)
    {
        Nome = nome;
        SalarioBase = salarioBase;
    }

    public abstract double CalcularSalario();
}

class Gerente : Funcionario
{
    public Gerente(string nome, double salarioBase) : base(nome, salarioBase) { }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.5;
    }
}

class Programador : Funcionario
{
    public Programador(string nome, double salarioBase) : base(nome, salarioBase) { }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.2;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Funcionario gerente = new Gerente("Ana", 8000);
        Funcionario programador = new Programador("Carlos", 5000);

        Console.WriteLine($"Salário do Gerente {gerente.Nome}: R$ {gerente.CalcularSalario():F2}");
        Console.WriteLine($"Salário do Programador {programador.Nome}: R$ {programador.CalcularSalario():F2}");
    }
}*/





