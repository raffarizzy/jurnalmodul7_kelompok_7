using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class GlossaryItem103022300035
    {
        public GlossDiv GlossDivData { get; set; }
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"../../../jurnal7_3_103022300035.json");
            var glossary = JsonSerializer.Deserialize<GlossaryItem103022300035>(jsonString);

            Console.WriteLine("Gloss Entry: ");
            Console.WriteLine($"ID: {glossary.GlossDivData.GlossList.GlossEntry.ID}");
            Console.WriteLine($"Sort As: {glossary.GlossDivData.GlossList.GlossEntry.SortAs}");
            Console.WriteLine($"Gloss Term: {glossary.GlossDivData.GlossList.GlossEntry.GlossTerm}");
            Console.WriteLine($"Acronym: {glossary.GlossDivData.GlossList.GlossEntry.Acronym}");
            Console.WriteLine($"Abbrev: {glossary.GlossDivData.GlossList.GlossEntry.Abbrev}");
            Console.WriteLine($"Gloss Def (para): {glossary.GlossDivData.GlossList.GlossEntry.GlossDef.para}");
            Console.WriteLine($"Gloss Def (Gloss See Also): " + string.Join(", ", glossary.GlossDivData.GlossList.GlossEntry.GlossDef.GlossSeeAlso));
            Console.WriteLine($"Gloss See: {glossary.GlossDivData.GlossList.GlossEntry.GlossSee}");
        }
        public class GlossDiv
        {
            [JsonPropertyName("title")]
            public string title { get; set; }
            [JsonPropertyName("GlossList")]
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            [JsonPropertyName("GlossEntry")]
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            [JsonPropertyName("ID")]
            public string ID { get; set; }
            [JsonPropertyName("SortAS")]
            public string SortAs { get; set; }
            [JsonPropertyName("GlossTerm")]
            public string GlossTerm { get; set; }
            [JsonPropertyName("Acronym")]
            public string Acronym { get; set; }
            [JsonPropertyName("Abbrev")]
            public string Abbrev { get; set; }
            [JsonPropertyName("GlossDef")]
            public GlossDef GlossDef { get; set; }
            [JsonPropertyName("GlossSee")]
            public string GlossSee { get; set; }
        }

        public class GlossDef
        {
            [JsonPropertyName("para")]
            public string para { get; set; }
            [JsonPropertyName("GlossSeeAlso")]
            public List<string> GlossSeeAlso { get; set; }
        }
    }
}
