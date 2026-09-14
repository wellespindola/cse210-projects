using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._question}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}~|~{entry._question}~|~{entry._response}"
                );
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        // Read the file first. If it does not exist, the current entries
        // will not be deleted.
        string[] lines = File.ReadAllLines(filename);

        // Only clear the current entries after the file was successfully read.
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            if (parts.Length >= 3)
            {
                string date = parts[0];
                string question = parts[1];
                string response = parts[2];

                Entry entry = new Entry(date, question, response);

                _entries.Add(entry);
            }
        }
    }
}