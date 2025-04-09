using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class Identitas
    {
        [JsonPropertyName("firstName")]
        public string Depan { get; set; }

        [JsonPropertyName("lastName")]
        public string Belakang { get; set; }

        [JsonPropertyName("gender")]
        public string Kelamin { get; set; }

        [JsonPropertyName("age")]
        public int Umur { get; set; }
    }

    public class Alamat
    {
        [JsonPropertyName("streetAddress")]
        public string Jalan { get; set; }

        [JsonPropertyName("city")]
        public string Kota { get; set; }

        [JsonPropertyName("state")]
        public string Kabupaten { get; set; }
    }

    public class Matkul
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class MatkulList
    {
        [JsonPropertyName("courses")]
        public List<Matkul> MataKuliah { get; set; }

    }
    public class DataMahasiswa103022300011
    {
        public static void ReadJSON() {
            string filepath = @"../../../jurnal7_1_103022300011.json";
            string jsonString = File.ReadAllText(filepath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Identitas data1 = JsonSerializer.Deserialize<Identitas>(jsonString, options);

            Console.WriteLine($"Nama {data1.Depan} {data1.Belakang} dengan umur {data1.Umur}");

            
            Alamat data2 = JsonSerializer.Deserialize<Alamat>(jsonString, options);

            Console.WriteLine($"Alamat pada jalan {data2.Jalan}, Kota {data2.Kota}, Kabupaten {data2.Kabupaten}");

            
            MatkulList data3 = JsonSerializer.Deserialize<MatkulList>(jsonString, options);

            Console.WriteLine("Daftar Mata kuliah yang diambil: ");
            int i = 1;
            foreach (var matakuliah in data3.MataKuliah) 
            {
                Console.WriteLine($"MK {i} {matakuliah.Code} - {matakuliah.Name}");
                i++;
            }
            
        }
    }
}
