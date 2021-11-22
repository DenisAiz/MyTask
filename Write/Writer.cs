namespace TestTask.Write
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using TestTask.Entities;


    public class Writer
    {
        private readonly string path = "Persons.csv";

        private readonly List<Person> _persons;

        public Writer(List<Person> Persons)
        {
            _persons = Persons;
        }

        public async Task Convert()
        {
            using StreamWriter writer = File.CreateText(path);

            await writer.WriteLineAsync("Name; Age; Position");

            for (var i = 0; i < _persons.Count; i++)
            {
                await writer.WriteLineAsync($"{_persons[i].Name};{_persons[i].Age};{_persons[i].Position}");
            }

            Console.WriteLine("Файл перезаписан в csv, нажмите любую клавишу для выхода.");
        }
    }
}
