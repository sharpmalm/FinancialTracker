namespace FinancialTracker;

using System.Linq.Expressions;

class FileHandler
{
    public string _fileName;

    public FileHandler(string fileName)
    {
        _fileName = fileName;
    }

    public List<String> ReadFileEntries()
    {
        List<String> entries = new List<String>();
        try
        {
            using (StreamReader sr = new StreamReader(_fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    entries.Add(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("The file does not exist");
            Console.WriteLine(ex.Message);
        }
        return entries;
    }

    public void WriteToFile(List<String> entries)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(_fileName))
            {
                foreach (String entry in entries)
                {
                    sw.WriteLine(entry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("The file does not exist");
            Console.WriteLine(ex.Message);
        }
    }

}