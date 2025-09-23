/*using System;

public class Animal
{
    public string Nome;
    public string som;
    public void EmitirSom(string som)
    {
        Console.WriteLine("rugidoo");
    }


}
public class Leao : Animal
{
    public void EmitirSom()
    {

    }

}
class Rodar
{
    static void Main()
    {
        Leao leao = new Leao();
        leao.Nome = "simba";
        leao.EmitirSom("qualquer som");

    }
}*/






/*using System;

public class Pedido {
    public string Anotando{  get; set; }

    public void Anotar()
    {
        Console.WriteLine("Pedido anotado");
    }

}
public class Item
{
    private Pedido pedido;

    public Item()
    {
        pedido = new Pedido();   
    }

    public void fazerlanche()
    {
        Console.WriteLine("pedido sendo feito");
        pedido.Anotar();
    }

}
class program
{
    static void Main()
    {
        Item item = new Item();
        item.fazerlanche();
    }
}*/






/*using System;

public interface IVeiculo
{
    void Mover();
}

public class Carro : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("O Carro esta se movendo");
    }

}
public class Bicicleta : IVeiculo
{
    public void Mover()
    {
        Console.WriteLine("A bicicleta esta se movendo");
    }
}
class Program
{
    static void Main()
    {
        IVeiculo veiculo = new Bicicleta();
        IVeiculo veiculo1 = new Carro();

        veiculo.Mover();
        veiculo1.Mover();

    }
}*/






using System;

public interface INadar
{
    void Nadar();

}
public interface IVoar
{
    void Voar();
}
public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("Pato está voando");
    }
    public void Nadar()
    {
        Console.WriteLine("Pato está nadando");
    }
}
public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A Aguia está voando");
    }
}
public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O Peixe esta nando");
    }
}
class program
{
    static void Main()
    {
        Pato pato = new Pato();
        pato.Nadar();
        pato.Voar();
        Aguia aguia = new Aguia();
        aguia.Voar();
        Peixe peixe = new Peixe();
        peixe.Nadar();
    }
}