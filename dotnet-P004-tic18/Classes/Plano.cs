namespace Namespace;
public class Plano {

    public string Titulo {get; set;}
    public double ValorMensal {get; set;}

    public Plano(string titulo, double valorMensal){
        Titulo = titulo;
        ValorMensal = valorMensal;
    }
}