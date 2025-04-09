using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class Member {
        [JsonPropertyName("firstName")]
        public string NamaDepan { get; set; }

        [JsonPropertyName("lastName")]
        public string NamaBelakang { get; set; }

        [JsonPropertyName("gender")]
        public string KelaminMember { get; set; }

        [JsonPropertyName("age")]
        public int UmurMember { get; set; }

        [JsonPropertyName("nim")]
        public string NIM_Member { get; set; }
    }

    public class MemberList
    {
        [JsonPropertyName("members")]
        public List<Member> DataMember { get; set; }
    }

    public class TeamMembers103022300011
    {
        public static void ReadJSON()
        {
            string filepath = @"../../../jurnal7_2_103022300011.json";
            string jsonString = File.ReadAllText(filepath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            MemberList data = JsonSerializer.Deserialize<MemberList>(jsonString);

            Console.WriteLine("Team member list: ");
            foreach (var members in data.DataMember)
            {
                Console.WriteLine($"{members.NIM_Member} {members.NamaDepan} {members.NamaBelakang} ({members.UmurMember} {members.KelaminMember})");
            }
        }
    }
}
