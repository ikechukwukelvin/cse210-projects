public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}\n");
            }
        }
    }

    public void LoadJournal(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':');
                string date = parts[0].Trim();
                string prompt = parts[1].Trim();
                string response = reader.ReadLine().Substring("Response:".Length).Trim();
                entries.Add(new Entry(prompt, response, date));
                reader.ReadLine(); // Consume empty line
            }
        }
    }
}
