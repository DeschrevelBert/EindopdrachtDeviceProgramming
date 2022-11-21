using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eindopdracht.Models
{
    public class StarWarsPeople
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("birth_year")]
        public string BirthYear { get; set; }

        [JsonProperty("eye_color")]
        public string EyeColor { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("homeworld")]
        public string HomeWorld { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
