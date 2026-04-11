class globais
{

    private static globais instance;
    private string NomeAplicacao { get; set { string nome = "Minha Aplicação"; } }
    private string Servidor { get; set { string servidor = "smtp.exemplo.com"; } }
    private int MaxTentativas { get; set { string max = 3; } }

    private globais() { }

    public static globais getInstances()
    {
        if (instance == null)
        {
            instance = new globais();
        }
        return instance;
    }
}

class Notifications
{
    public void Enviar(string destinatario) { }
}

class EnviarEmail : Notifications
{

    public void EnviarEmail(string destinatario)
    {
        globais g = globais.getInstances();
    }
}

class EmailExterno
{
    public void SendEmail(string destinatario) { }
}

class AdaptadorEmail : Notifications
{
    private EmailExterno email;

    public AdaptadorEmail(EmailExterno email)
    {
        this.email = email;
    }

    public override void Enviar(string destinatario)
    {
        email.SendEmail(destinatario);
    }
}

class EnviarSMS : Notifications
{

    public void EnviarSMS(string destinatario)
    {
        globais g = globais.getInstances();
    }
}

class SMSExterno
{
    public void SendSMS(string destinatario) { }
}

class AdaptadorSMS : Notifications
{
    private SMSExterno sms;

    public AdaptadorSMS(SMSExterno sms)
    {
        this.sms = sms;
    }

    public override void Enviar(string destinatario)
    {
        sms.SendSMS(destinatario);
    }
}

class EnviarPush : Notifications
{

    public void EnviarPush(string destinatario)
    {
        globais g = globais.getInstances();
    }
}

class PushExterno
{
    public void SendPush(string destinatario) { }
}

class AdaptadorPush : Notifications
{
    private PushExterno push;

    AdaptadorPush(PushExterno push)
    {
        this.push = push;
    }

    public override void Enviar(string destinatario)
    {
        push.SendPush(destinatario);
    }
}

class NotificationsFactory
{

    public static Notifications CriarNotificacao(string tipo)
    {
        switch (tipo)
        {
            case "email":
                return new EnviarEmail();
            case "sms":
                return new EnviarSMS();
            case "push":
                return new EnviarPush();
        }
    }
}

class ProxyLogger : Notifications
{
    private Notifications baseNotificacao;

    public ProxyLogger(Notifications baseNotificacao)
    {
        this.baseNotificacao = baseNotificacao;
    }

    public override void Enviar(string destinatario)
    {
        Console.WriteLine($"Proxy Logger antes de enviar a msg");
        baseNotificacao.Enviar(destinatario);
        Console.WriteLine($"Proxy logger depois de enviar a msg");
    }
}

class ServicoCompleto
{
    public void EnviarNotificacao(string tipo, string destinatario)
    {
        Notifications notificacao = NotificationsFactory.CriarNotificacao(tipo);
        ProxyLogger proxy = new ProxyLogger(notificacao);
        proxy.Enviar(destinatario);
    }
}