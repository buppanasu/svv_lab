public interface IFileReader
{
    string[] Read(string path);
}

public class FileReader : IFileReader
{
    public string[] Read(string path)
    {
        // Implement the file reading logic here
        return File.ReadAllLines(path);
    }
}
