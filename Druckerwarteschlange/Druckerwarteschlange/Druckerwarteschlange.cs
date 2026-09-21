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
        if (warteschlange.Count == 0)
        {
            return null;
        }
        
        return warteschlange.Dequeue();
    }

    public string? Naechster()
    {
        
    }

    public int Offen()
    {
        get;
    }
}