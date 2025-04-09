using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class MemberDzul
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("nim")]
        public string Nim { get; set; }
    }

    public class MemberListDzul
    {
        [JsonPropertyName("members")]
        public List<MemberDzul> Members { get; set; }
    }
    class TeamMembers103022300021
    {
        public static void ReadJSON()
        {

            string filePath = @"../../../jurnal7_2_103022300021.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            MemberListDzul data = JsonSerializer.Deserialize<MemberListDzul>(jsonString, options);

            Console.WriteLine("Daftar Member:");
            int i = 1;
            foreach (var member in data.Members)
            {
                Console.WriteLine($"Member {i}: {member.FirstName} {member.LastName}, gender: {member.Gender}, age: {member.Age} ,nim: {member.Nim}");
                i++;
            }
        }
    }
}
