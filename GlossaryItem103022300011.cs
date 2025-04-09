using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace jurnalmodul7_kelompok_7
{
    public class Glossary {
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class GlossDiv
    {
        [JsonPropertyName("title")]
        public string TitleDiv { get; set; }
    }

    public class GlossDef {
        [JsonPropertyName("para")]
        public string Para { get; set; }
        
        [JsonPropertyName("GlossSeeAlso")]
        public string GlossSeeAlso { get; set; }

    }

    public class GlossEntry
    {

    }

    class GlossaryItem103022300011
    {
    }
}
