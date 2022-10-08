using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NEOMVC.Models
{
    public class NEOViewModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public int Name { get; set; }

        [JsonPropertyName("miss_distance")]
        public string MissDistance { get; set; }

        [JsonPropertyName("close_approach_date")]
        public string ApproachDate { get; set; }

        [JsonPropertyName("is_potentially_hazardous_asteroid")]
        public bool IsHazard { get; set; }
        
    }
}