using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
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

    public class DataMahasiswa103022330138
    {
        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022330138.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString, options);
            Console.WriteLine($"Nama depan : {data.firstName}\nNama belakang : {data.lastName}\nKelamin : {data.gender}\nUmur : {data.age}\n" +
                $"Alamat rumah : {data.address.streetAddress}, {data.address.city}, {data.address.state}\n" +
                $"Daftar mata kuliah yang diambil : ");
            int i = 1;
            foreach (var course in data.courses)
            {
                Console.WriteLine($"MK {i} {course.name} - {course.code}");
                i++;
            }
        }
    }
}
