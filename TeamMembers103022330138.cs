using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class Member
    {
        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("gender")]
        public string gender { get; set; }

        [JsonPropertyName("age")]
        public int age { get; set; }

        [JsonPropertyName("nim")]
        public string nim { get; set; }
    }

    public class MembersList
    {
        [JsonPropertyName("members")]
        public List<Member> members { get; set; }
    }
    
    public class TeamMembers103022330138
    {
        public static void ReadJSON()
        {
            string filePath = @"../../../jurnal7_2_103022330138.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            MembersList data = JsonSerializer.Deserialize<MembersList>(jsonString, options);
            
            Console.WriteLine($"Daftar anggota kelompok 7 : ");
            int i = 1;
            foreach (var members in data.members)
            {
                Console.WriteLine($"{members.nim} {members.firstName} {members.lastName} ({members.age} {members.gender})");
                i++;
            }
        }
    }
}
