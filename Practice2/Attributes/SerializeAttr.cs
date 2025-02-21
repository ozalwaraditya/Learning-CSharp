using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Practice2.Attributes
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class SerializeAtrri
    {
        public static void main(string[] args)
        {
            Person person = new Person { Name = "John Doe", Id = 30 };

            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText("person.json", jsonString);

            string readJsonString = File.ReadAllText("person.json");
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(readJsonString);

            Console.WriteLine($"Deserialized Name: {deserializedPerson.Name}, Id: {deserializedPerson.Id}");
        }
    }
}
