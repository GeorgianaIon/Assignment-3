using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AdultsServer.Models
{
    public class Person
    {
        [Key]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Height")]
        public int Height { get; set; }
        [JsonPropertyName("Age")]
        public int Age { get; set; }
        [JsonPropertyName("FirstName")]
        [Required, MaxLength(150)]
        public string FirstName { get; set; }
        [JsonPropertyName("Sex")]
        [Required, MaxLength(150)]
        public string Sex { get; set; }
        [JsonPropertyName("EyeColor")]
        [Required, MaxLength(150)]
        public string EyeColor { get; set; }
        [JsonPropertyName("HairColor")]
        [Required, MaxLength(150)]
        public string HairColor { get; set; }
        [JsonPropertyName("LastName")]
        [Required, MaxLength(150)]
        public string LastName { get; set; }
        [JsonPropertyName("Weight")]
        public double Weight { get; set; }
    }
}