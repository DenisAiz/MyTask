namespace TestTask.Entities
{
    using System.Text.Json.Serialization;

    public class Person
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public string Age { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }
    }
}
