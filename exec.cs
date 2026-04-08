class globais{

    private static globais instance;
    private String nomeAplicacao;
    private String servidor;
    private int maxTentativas;

    private globais(){
        this.nomeAplicacao = "Minha Aplicação";
        this.servidor = "smtp.exemplo.com";
        this.maxTentativas = 3;
    }

    public static globais getInstances(){
        if(instance == null){
            instance = new globais();
        }
        return instance;
    }

    public String getNomeAplicacao(){
        return this.nomeAplicacao;
    }

    public String getServidor(){
        return this.servidor;
    }

    public int getMaxTentativas(){
        return this.maxTentativas;
    }

}

class Notifications{
     void enviar(String destinatario){}
}

class enviarEmail implements Notifications{

    public void enviarEmail(String destinatario){
        globais g = globais.getInstances();
        g.getNomeAplicacao();
        g.getServidor();
        g.getMaxTentativas();
    }
}

class enviarSMS implements Notifications{

    public void enviarSMS(String destinatario){
        globais g = globais.getInstances();
        g.getNomeAplicacao();
        g.getServidor();
        g.getMaxTentativas();
    }
}

class enviarPush implements Notifications{

    public void enviarPush(String destinatario){
        globais g = globais.getInstances();
        g.getNomeAplicacao();
        g.getServidor();
        g.getMaxTentativas();
    }
}

class NotificationsFactory{

    public static Notifications criarNotificacao(String tipo){
    }
}

class ServicoCompleto{

    public void enviarNotificacao(String tipo, String destinatario){
        Notifications notificacao = NotificationsFactory.criarNotificacao(tipo);
        notificacao.enviar(destinatario);
    }
}
