using EnterWordProgramm;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Введите английское слово для поиска");
        string userWrite = Console.ReadLine();
        string responsResult = await DictionaryAPI.EntriesAPI(userWrite.ToLower());
        Console.WriteLine(responsResult);
    }
}
