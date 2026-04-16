abstract class Bebida
{
    public abstract string Descricao();
    public abstract double Preco();
}

class CafeExpresso : Bebida
{
    public override string Descricao() => "Café Expresso";
    public override double Preco() => 3.0;
}

class Cappuccino : Bebida
{
    public override string Descricao() => "Cappuccino";
    public override double Preco() => 5.0;
}

class Cha : Bebida
{
    public override string Descricao() => "Chá";
    public override double Preco() => 2.0;
}

abstract class Adicional : Bebida
{
    protected Bebida bebida;

    public Adicional(Bebida bebida)
    {
        this.bebida = bebida;
    }
}

class Leite : Adicional
{
    public Leite(Bebida bebida) : base(bebida) { }

    public override string Descricao() => bebida.Descricao() + ", Leite";
    public override double Preco() => bebida.Preco() + 1.50;
}

class Canela : Adicional
{
    public Canela(Bebida bebida) : base(bebida) { }

    public override string Descricao() => bebida.Descricao() + ", Canela";
    public override double Preco() => bebida.Preco() + 0.5;
}

class Chocolate : Adicional
{
    public Chocolate(Bebida bebida) : base(bebida) { }

    public override string Descricao() => bebida.Descricao() + ", Chocolate";
    public override double Preco() => bebida.Preco() + 2.0;
}

class Program
{
    static void Main(string[] args)
    {
        Bebida bebida = new Leite(new Canela(new CafeExpresso()));

        Console.WriteLine($"{bebida.Descricao()} - Preço: {bebida.Preco()}");

    }
}