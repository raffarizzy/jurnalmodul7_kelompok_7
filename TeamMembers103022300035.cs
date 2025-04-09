using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class TeamMembers103022300035
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

        public class Members
        {
            [JsonPropertyName("members")]
            public List<Member> members { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"../../../jurnal7_2_103022300035.json");
            Members data = JsonSerializer.Deserialize<Members>(jsonString);

            Console.WriteLine("\n\n\nTeam member list:");
            foreach (var member in data.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
    }
}
