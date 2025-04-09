using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class CourseDzul
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class AddressDzul
    {
        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }

    public class MahasiswaDzul
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("gender")]
        public String Gender { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("address")]
        public AddressDzul Address { get; set; }

        [JsonPropertyName("courses")]
        public CourseDzul[] Courses { get; set; }
    }

   
    class DataMahasiswa103022300021
    {
        public static void ReadJSON()
        {
            string filePath = @"../../../jurnal7_1_103022300021.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            MahasiswaDzul data = JsonSerializer.Deserialize<MahasiswaDzul>(jsonString, options);

            Console.WriteLine($"Nama: {data.FirstName} {data.LastName}");
            Console.WriteLine($"Gender: {data.Gender}");
            Console.WriteLine($"Age: {data.Age}");

            Console.WriteLine($"Alamat: {data.Address.StreetAddress}, Kota {data.Address.City}, Kabupaten {data.Address.State}");

            int i = 1;
            foreach (var course in data.Courses)
            {
                Console.WriteLine($"MK {i} {course.Code} - {course.Name}");
                i++;
            }

        }

    }
}

