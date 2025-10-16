using System;
using System.Threading;
using System.Threading.Tasks;
class Program
 {  
    static async Task Main()
    {
        string[] files = { "Файл 1", "Файл 2", "Файл 3" };

        Console.WriteLine("Synchronous:");
        foreach (var file in files)
        {
            string result = ProcessData(file);
            Console.WriteLine(result);
        }

        Console.WriteLine("\nAsynchronous:");
        Task<string>[] tasks = files.Select(ProcessDataAsync).ToArray();
        string[] results = await Task.WhenAll(tasks);

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
    static string ProcessData(string dataName)
    {
        Console.WriteLine($"Processing started: {dataName}");
        Thread.Sleep(3000);
        return $"Processing completed: {dataName} in 3 seconds";
    }
    static async Task<string> ProcessDataAsync(string dataName)
    {
        Console.WriteLine($"Processing started: {dataName}");
        await Task.Delay(3000);
        return $"Processing completed: {dataName} in 3 seconds";
    }
}
