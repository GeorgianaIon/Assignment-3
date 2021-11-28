using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdultsServer.Models
{
    public class User
    {
        [JsonPropertyName("UserName")]
        [Key]
        public string UserName { get; set; }
        [JsonPropertyName("Domain")]
        public string Domain { get; set; }
        [JsonPropertyName("Password")]
        public string Password { get; set; }
        [JsonPropertyName("City")]
        public string City{ get; set; }
        [JsonPropertyName("BirthYear")]
        public int BirthYear { get; set; }
        [JsonPropertyName("Role")]
        public string Role { get; set; }
        [JsonPropertyName("SecurityLevel")]
        public int SecurityLevel { get; set; }
    }
}