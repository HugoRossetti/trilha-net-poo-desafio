namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
    public string Numero { get; set; }
    private string Modelo { get; set; }
    private string IMEI { get; set; }
    private int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando para um contato...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo uma ligação...");
    }

    public abstract void InstalarAplicativo(string nome);
    }
}