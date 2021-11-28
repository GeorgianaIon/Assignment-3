using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdultsServer.Models
{
    public class Job
    {
        [JsonPropertyName("JobTitle")]
        [Key]
        public string JobTitle { get; set; }
        [JsonPropertyName("Salary")]
        public int Salary { get; set; }
    }
}