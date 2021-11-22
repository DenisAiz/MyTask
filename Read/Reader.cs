namespace TestTask.Read
{
    using System;
    using System.IO;
    using System.Text.Json;
    using System.Threading.Tasks;
    using TestTask.Write;
    using TestTask.Entities;

    public class Reader
    {
        public static async Task ReaderFile()
        {
            string readFile = File.ReadAllText("Persons.json");

            var deserialize = JsonSerializer.Deserialize<AllPersons>(readFile);

            await new Writer(deserialize.Persons).Convert();

            Console.ReadKey();
        }
    }
}
