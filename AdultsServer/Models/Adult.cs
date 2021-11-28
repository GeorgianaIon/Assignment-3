using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdultsServer.Models
{
    public class Adult : Person
    {
        [JsonPropertyName("Job")]
        public Job Job { get; set; }
    }
}