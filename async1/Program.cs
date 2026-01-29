using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

class Ejemplo1
{
    public static async Task<int> GetPageLengthAsync(string endpoint)
    {
        using var client = new HttpClient();
        byte[] content = await client.GetByteArrayAsync(endpoint);
        return content.Length;
    }

    public static async IAsyncEnumerable<int> ReadSequence()
    {
        int index = 0;
        while (index < 100)
        {
            int[] nextChunk = await GetNextChunk(index);
            
            if (nextChunk.Length == 0)
                yield break;

            foreach (var item in nextChunk)
            {
                yield return item;
            }
            index += nextChunk.Length; 
        }
    }

    private static async Task<int[]> GetNextChunk(int index)
    {
        await Task.Delay(100); 
        if (index >= 20) return []; 
        return [index + 1, index + 2, index + 3];
    }

    // CORRECCIÓN: Cambiamos 'void' por 'async Task'
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando lectura de secuencia asíncrona...");

        // Ahora el await foreach funcionará correctamente
        await foreach (var item in ReadSequence())
        {
            Console.WriteLine($"Recibido: {item}");
        }

        Console.WriteLine("Proceso finalizado.");
    }
}