using System;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            
            entry.Display();
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            
            
                outputFile.WriteLine(_entries);
            
        }
    }

    public void Load(string filename)
    {
        string[] journal = System.IO.File.ReadAllLines(filename);
        
    }
}
