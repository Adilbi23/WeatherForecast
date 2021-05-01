using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class StarWarsCharacter
    {
        [JsonProperty("name")]
        public int Name { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
    }
}
