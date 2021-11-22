namespace TestTask.Entities
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class AllPersons
    {
        [JsonPropertyName("persons")]
        public List<Person> Persons { get; set; }        
    }
}
