using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class DataMahasiswa103022300035
    {
        public class Address
        {
            [JsonPropertyName("streetAddress")]
            public string streetAddress { get; set; }
            [JsonPropertyName("city")]
            public string city { get; set; }
            [JsonPropertyName("state")]
            public string state { get; set; }
        }

        public class Course
        {
            [JsonPropertyName("code")]
            public string code { get; set; }
            [JsonPropertyName("name")]
            public string name { get; set; }
        }

        public class Mahasiswa
        {
            [JsonPropertyName("firstName")]
            public string firstName { get; set; }
            [JsonPropertyName("lastName")]
            public string lastName { get; set; }
            [JsonPropertyName("gender")]
            public string gender { get; set; }
            [JsonPropertyName("age")]
            public int age { get; set; }
            [JsonPropertyName("address")]
            public Address address { get; set; }
            [JsonPropertyName("courses")]
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"../../../jurnal7_1_103022300035.json");
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"{data.firstName} {data.lastName} {data.age} - {data.gender}");
            Console.WriteLine($"Alamat: {data.address.streetAddress}, {data.address.city}, {data.address.state}");
            Console.WriteLine("\nMata Kuliah yang diambil:");
            foreach (var course in data.courses)
            {
                Console.WriteLine($"{course.code} - {course.name}");
            }
        }
    }
}
