class TV
{
    public void LigarTV()
    {
        Console.WriteLine("TV ligada");
    }

    public void DesligarTV()
    {
        Console.WriteLine("TV desligada");
    }
}

class Projetor
{
    public void LigarProjetor()
    {
        Console.WriteLine("Projetor ligado");
    }

    public void DesligarProjetor()
    {
        Console.WriteLine("Projetor desligado");
    }
}

class Receiver
{
    public void LigarReceiver()
    {
        Console.WriteLine("Receiver ligado");
    }

    public void DesligarReceiver()
    {
        Console.WriteLine("Receiver desligado");
    }
}

class Player
{
    public void LigarPlayer()
    {
        Console.WriteLine("Player ligado");
    }

    public void DesligarPlayer()
    {
        Console.WriteLine("Player desligado");
    }
}

class Som
{
    public void LigarSom()
    {
        Console.WriteLine("Som ligado");
    }

    public void DesligarSom()
    {
        Console.WriteLine("Som desligado");
    }
}

class LuzAmbiente
{
    public void LigarLuz()
    {
        Console.WriteLine("Luz ambiente ligada");
    }

    public void DesligarLuz()
    {
        Console.WriteLine("Luz ambiente desligada");
    }
}

public class HomeTheather
{
    private TV tv;
    private Projetor projetor;
    private Receiver receiver;
    private Player player;
    private Som som;
    private LuzAmbiente luz;

    public HomeTheather()
    {
        this.tv = new TV();
        this.projetor = new Projetor();
        this.receiver = new Receiver();
        this.player = new Player();
        this.som = new Som();
        this.luz = new LuzAmbiente();
    }

    public void AssistirFilme()
    {
        Console.WriteLine("Preparando para assistir um filme...");
        tv.LigarTV();
        projetor.LigarProjetor();
        receiver.LigarReceiver();
        player.LigarPlayer();
        som.LigarSom();
        luz.DesligarLuz();
    }

    public void OuvirMusica()
    {
        Console.WriteLine("Preparando para ouvir música...");
        tv.DesligarTV();
        projetor.DesligarProjetor();
        receiver.LigarReceiver();
        player.DesligarPlayer();
        som.LigarSom();
        luz.LigarLuz();
    }
}

class Program
{
    static void Main(string[] args)
    {
        HomeTheather homeTheather = new HomeTheather();
        homeTheather.AssistirFilme();
    }
}