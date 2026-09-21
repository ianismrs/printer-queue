namespace Druckerwarteschlange;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new();

        string pfad = "toprint.txt";

        foreach (string zeile in File.ReadAllLines(pfad))
        {
            if (string.IsNullOrWhiteSpace(zeile) || zeile.StartsWith("#"))
                continue;

            string[] teile = zeile.Split(';');

            switch (teile[0].ToUpper())
            {
                case "AUFTRAG":
                    if (teile.Length > 1)
                    {
                        queue.Enqueue(teile[1]);
                        Console.WriteLine($"Auftrag hinzugefügt: {teile[1]}");
                    }
                    break;

                case "NAECHSTER":
                    Console.WriteLine(
                        queue.Count > 0
                            ? $"Nächster: {queue.Peek()}"
                            : "Keine Aufträge vorhanden");
                    break;

                case "DRUCKE":
                    Console.WriteLine(
                        queue.Count > 0
                            ? $"Gedruckt: {queue.Dequeue()}"
                            : "Keine Aufträge vorhanden");
                    break;

                case "OFFEN":
                    Console.WriteLine($"Offene Aufträge: {queue.Count}");
                    break;
            }
        }
    }
}