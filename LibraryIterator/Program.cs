namespace LibraryIterator;

class Program
{
    static void Main(string[] args)
    {
        var s = new LibraryAgregator(12);
        foreach (var VARIABLE in s.Library)
        {
            Console.WriteLine($"{VARIABLE.name} - {VARIABLE.id}");
        }
    }
}