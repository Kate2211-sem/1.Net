// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;
using System;
class Program
{

    static async Task Main()
    {
        Console.WriteLine("Synchronous");
        string result1 = ProcessData("Файл 1");
        Console.WriteLine(result1);
        string result2 = ProcessData("Файл 2");
        Console.WriteLine(result2);
        string result3 = ProcessData("Файл 3");
        Console.WriteLine(result3);


        Console.WriteLine("Asynchronous");
        Task<string> task1 = ProcessDataAsync("Файл 1");
        Task<string> task2 = ProcessDataAsync("Файл 2");
        Task<string> task3 = ProcessDataAsync("Файл 3");
        string[] results = await Task.WhenAll(task1, task2, task3);
        Console.WriteLine(results[0]);
        Console.WriteLine(results[1]);
        Console.WriteLine(results[2]);

    }

    static string ProcessData(string dataName)
    {
        Console.WriteLine($"Processing started {dataName}");
        Thread.Sleep(3000);
        return $"Processing completed {dataName}  in 3 seconds";



    }

    static async Task<string> ProcessDataAsync(string dataName)
    {
        Console.WriteLine($"Processing started {dataName}");
        await Task.Delay(3000);
        return $"Processing completed {dataName}  in 3 seconds";
    }
}















