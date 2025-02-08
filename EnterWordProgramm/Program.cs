using EnterWordProgramm;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Введите английское слово для поиска");
        string userWrite = Console.ReadLine();
        await DictionaryAPI.EntriesAPI(userWrite.ToLower());
    }
}
