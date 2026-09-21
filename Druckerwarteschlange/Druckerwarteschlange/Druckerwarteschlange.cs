namespace Druckerwarteschlange;

public class Druckerwarteschlange
{
    private readonly Queue<string> warteschlange = new();
    public void Auftrag(string dokument)
    {
        warteschlange.Enqueue(dokument);
    }

    public string? Drucke()
    {
        
    }

    public string? Naechster()
    {
        
    }

    public int Offen()
    {
        get;
    }
}